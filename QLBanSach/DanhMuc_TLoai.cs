using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Data.Odbc;
namespace QLBanSach
{
    public partial class DanhMuc_TLoai : Form
    {
        public DanhMuc_TLoai()
        {

            InitializeComponent();
            FillCombo("SELECT MaDM,TenDM FROM DANHMUCSACH", comboBoxTenDM, "MaDM", "TenDM");
            comboBoxTenDM.SelectedIndex = -1;
            FillCombo("SELECT MaDM,TenDM FROM DANHMUCSACH", comboBoxDM_TL, "MaDM", "TenDM");

            comboBoxTenDM.SelectedIndex = -1;
            FillCombo("SELECT MaTL,TenTL FROM THELOAI", comboBoxTenTL, "MaTL", "TenTL");
            comboBoxTenDM.SelectedIndex = -1;
        }
        void loadDataDM()
        {
            DataTable table1 = new DataTable();
            dataGridViewDanhMuc.DataSource = null;
            dataGridViewDanhMuc.Refresh();

            string query1 = "select * from DanhMucSach";

            table1 = Program.da.readDatathroughAdapter(query1);
            dataGridViewDanhMuc.DataSource = table1;

           
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            // conn.Open();

            //SqlCommand cmd = new SqlCommand(sql);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            //da.Fill(table);
            cbo.Refresh();
            cbo.DataSource = null;
            table = Program.da.readDatathroughAdapter(sql);
            cbo.DataSource = table;

            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị


        } 

        private void buttonXoaDM_Click(object sender, EventArgs e)
        {
            SqlCommand xoa = new SqlCommand("delete DanhMucSach  where MaDM='" + textBoxMaDM.Text + "'");
            if (textBoxMaDM.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ma can xoa!");
            else
            {
                Program.da.executeQuery(xoa);

                MessageBox.Show("xoa thanh cong!");
                loadDataDM();
            }
        }

        private void buttonThemDM_Click(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand("insert into DanhMucSach values ('" + comboBoxTenDM.Text + "')");
            string query = "select * from  DanhMucSach where TenDM='" + comboBoxTenDM.Text + "'";
            DataTable dtU = new DataTable();
            
            // SqlCommand de = new SqlCommand(query);
            dtU = Program.da.readDatathroughAdapter(query);
            if (dtU.Rows.Count != 0)
            {
                MessageBox.Show("Trung du lieu, xin nhap lai!");

            }
            else
            {
                if (!textBoxMaDM.Text.Equals(""))
                    MessageBox.Show("Khong duoc nhap ma danh muc!");
                if (comboBoxTenDM.Text.Equals(""))
                    MessageBox.Show("Ban chua nhap ten danh muc!");
                else
                {
                    Program.da.executeQuery(command);
                    MessageBox.Show("Them thanh cong!");
                    loadDataDM();
                }
            }
            
        }

        private void buttonSuaDM_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update DanhMucSach set TenDM='" + comboBoxTenDM.Text + "' where MaDM ='" + int.Parse(textBoxMaDM.Text) + "'");
            if (textBoxMaDM.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ma can sua!");
            else
            {


                Program.da.executeQuery(update);


                MessageBox.Show("Sua thanh cong!");
                loadDataDM();
            }
        }

        private void buttonTimDM_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            dataGridViewDanhMuc.DataSource = null;
            dataGridViewDanhMuc.Refresh();
            if (!textBoxMaDM.Text.Equals(""))
            {
                string query = "select * from DanhMucSach where MaDM='" + int.Parse(textBoxMaDM.Text) + "'";

                table = Program.da.readDatathroughAdapter(query);
                dataGridViewDanhMuc.DataSource = table;
            }
            else
            {
                string query = "select * from DanhMucSach where TenDM='" + comboBoxTenDM.Text + "'";

                table = Program.da.readDatathroughAdapter(query);
                dataGridViewDanhMuc.DataSource = table;
            }
        }

        private void buttonResetDM_Click(object sender, EventArgs e)
        {
            textBoxMaDM.Text = "";
            comboBoxTenDM.Text = "";
            loadDataDM();
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////
        /// </summary>
        void loadDataTL()
        {
            DataTable table1 = new DataTable();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            string query1 = "select * from TheLoai";

            table1 = Program.da.readDatathroughAdapter(query1);
            dataGridView1.DataSource = table1;
           
        }
        private void buttonThemTL_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into " + "TheLoai " + "values('" + int.Parse(comboBoxDM_TL.SelectedValue.ToString()) + "','" + (comboBoxTenTL.Text) + "')");

            if (!textBoxMaTL.Text.Equals(""))
                MessageBox.Show("Khong duoc nhap ma the loai!");
            if (comboBoxTenTL.Text.Equals("") || comboBoxDM_TL.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ten the loai hoac ma danh muc!");
            else
            {
                Program.da.executeQuery(command);
                MessageBox.Show("Them thanh cong the loai!");
                loadDataTL();
            }
        }

        private void buttonSuaTL_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update TheLoai set MaDM='" + int.Parse(comboBoxDM_TL.SelectedValue.ToString()) + "',TenTL='" + comboBoxTenTL.SelectedValue.ToString() + "' where MaTL ='" + int.Parse(textBoxMaTL.Text) + "'");
            if (textBoxMaTL.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ma can sua!");
            else
            {


                Program.da.executeQuery(update);


                MessageBox.Show("Sua thanh cong the loai!");
                loadDataTL();
            }
        }

        private void buttonXoaTL_Click(object sender, EventArgs e)
        {
            SqlCommand xoa = new SqlCommand("delete TheLoai  where MaTL='" + textBoxMaTL.Text + "'");
            if (textBoxMaTL.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ma can xoa!");
            else
            {
                Program.da.executeQuery(xoa);

                MessageBox.Show("xoa thanh cong!");
                loadDataTL();
            }
        }

        private void buttonTimTL_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            if (!textBoxMaTL.Text.Equals(""))
            {
                string query = "select * from TheLoai where MaTL='" + int.Parse(textBoxMaTL.Text) + "'";

                table = Program.da.readDatathroughAdapter(query);
                dataGridView1.DataSource = table;
            }
            else
            {
                string query = "select * from TheLoai where TenTL='" + comboBoxTenTL.Text + "'";

                table = Program.da.readDatathroughAdapter(query);
                dataGridView1.DataSource = table;
            }
        }

        private void buttonRessetTL_Click(object sender, EventArgs e)
        {
            textBoxMaTL.Text = "";
            comboBoxTenTL.Text= "";
            comboBoxDM_TL.Text = "";
            loadDataTL();
        }

        private void dataGridViewDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewDanhMuc.CurrentRow.Index;
            textBoxMaDM.Text = dataGridViewDanhMuc.Rows[i].Cells[0].Value.ToString();
            comboBoxTenDM.DisplayMember= dataGridViewDanhMuc.Rows[i].Cells[1].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewTheLoai.CurrentRow.Index;
            textBoxMaTL.Text = dataGridViewTheLoai.Rows[i].Cells[0].Value.ToString();
            comboBoxDM_TL.DisplayMember = dataGridViewTheLoai.Rows[i].Cells[1].Value.ToString();
            comboBoxTenTL.DisplayMember = dataGridViewTheLoai.Rows[i].Cells[2].Value.ToString();
        }

        private void DanhMuc_TLoai_Load(object sender, EventArgs e)
        {

        }

    }
}

