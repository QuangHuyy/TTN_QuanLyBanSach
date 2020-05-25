using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanSach
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        public MainForm()
        {
            InitializeComponent();
            LoadComponents();
        }

        public void LoadComponents()
        {
            CustomizeDesing();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            if (Program.IsLoggedIn() == false)
            {
                panelMenu.Enabled = false;
                OpenChildForm(new FormDangNhap(this), null);
            }
            else
            {
                panelMenu.Enabled = true;
                OpenChildForm(new FormThanhToan(this), btnCheckout);
            }
        }
        void CustomizeDesing()
        {
            panelIndexSubMenu.Visible = false;
        }
        void HideSubMenu()
        {
            if (panelIndexSubMenu.Visible == true)
                panelIndexSubMenu.Visible = false;
        }

        #region make form draggable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelNav_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private int tolerance = 16;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelDesktopPane.Region = region;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        #endregion
        void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                if (currentButton != (Button) btnSender)
                {
                    currentButton = (Button) btnSender;
                    currentButton.BackColor = Color.FromArgb(75, 77, 106);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenuButton.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(17, 20, 55);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else if (previousBtn.GetType() == typeof(Panel))
                {
                    foreach(Control c in previousBtn.Controls)
                    {
                        if (c.GetType() == typeof(Button))
                        {
                            c.BackColor = Color.FromArgb(0, 10, 80);
                            c.ForeColor = Color.Gainsboro;
                            c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        }
                    }
                }
            }
        }

        #region Navigation Buttons
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBoxRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pictureBoxMaximize.Visible = true;
            pictureBoxRestore.Visible = false;
        }
        private void pictureBoxMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pictureBoxMaximize.Visible = false;
            pictureBoxRestore.Visible = true;
        }
        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            pictureBoxMinimize.BackColor = Color.FromArgb(115, 247, 221);
        }
        private void pictureBoxMinimize_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMinimize.BackColor = Color.FromArgb(53, 61, 73);
        }
        private void pictureBoxRestore_MouseHover(object sender, EventArgs e)
        {
            pictureBoxRestore.BackColor = Color.FromArgb(115, 247, 221);
        }
        private void pictureBoxRestore_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRestore.BackColor = Color.FromArgb(53, 61, 73);
        }
        private void pictureBoxMaximize_MouseHover(object sender, EventArgs e)
        {
            pictureBoxMaximize.BackColor = Color.FromArgb(115, 247, 221);
        }
        private void pictureBoxMaximize_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMaximize.BackColor = Color.FromArgb(53, 61, 73);
        }
        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.FromArgb(115, 247, 221);
        }
        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.BackColor = Color.FromArgb(53, 61, 73);
        }
        #endregion

        #region buttonClick
        public void btnCheckout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThanhToan(this), sender);
            HideSubMenu();
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new FormNhapSach(), sender);
            HideSubMenu();
        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            //ShowSubMenu(panelStatisticsSubMenu);
            OpenChildForm(new FormBanChay(), sender);
            HideSubMenu();
        }
        private void btnIndex_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowSubMenu(panelIndexSubMenu);
        }
        private void btnAuthor_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new FormThongTin(), sender);
        }
        private void btnTranslator_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new FormDichGia(), sender);
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new FormDanhMuc_TLoai(), sender);
        }
        private void btnLanguage_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new FormNgonNgu(), sender);
        }
        private void btnRevenue_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new FormDoanhThu(), sender);
            //HideSubMenu();
        }
        private void btnTrending_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new FormBanChay(), sender);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new FormTimKiem(), sender);
            HideSubMenu();
        }
        #endregion
    }
}
