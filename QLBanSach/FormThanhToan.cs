using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QLBanSach
{
    public partial class FormThanhToan : Form
    {
        public FormThanhToan()
        {
            InitializeComponent();
            Populate();
            SetDataGridView();
            labelTotal.Text = totalMoney.ToString();
        }
        private ListViewItem selectingItem = null;
        private int checkoutIndex = 1;
        double totalMoney = 0;

        void SetDataGridView()
        {
            dataGridViewCheckout.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCheckout.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCheckout.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCheckout.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCheckout.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCheckout.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridViewSearch.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSearch.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSearch.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSearch.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridViewSearch.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCheckout.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //dataGridViewCheckout.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //dataGridViewSearch.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCheckout.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewSearch.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewSearch.ForeColor = Color.White;
            dataGridViewCheckout.ForeColor = Color.White;

            dataGridViewSearch.DefaultCellStyle.BackColor = Color.FromArgb(17, 20, 55);
            dataGridViewCheckout.DefaultCellStyle.BackColor = Color.FromArgb(17, 20, 55);


            //dataGridView1.Columns[0].Width = 50;
            //dataGridView1.Columns[1].Width = 200;
            //dataGridView1.Columns[2].Width = 150;
            //dataGridView1.Columns[3].Width = 100;
            //dataGridView1.Columns[4].Width = 150;
        }
        private void Populate()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100,50);

            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            wanted_path += "\\Barcode";
            String[] paths = Directory.GetFiles(wanted_path);

            int i = 0;
            try
            {
                foreach(String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                    listView1.Items.Add("", i++);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            listView1.LargeImageList = imgs;
            
            //for (int i = 0; i < imgs.Images.Count; i++)
            //{
            //    listView1.Items.Add("", i);
            //}
        }

        BarcodeReader reader;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewCheckout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCheckout.Columns[e.ColumnIndex].Name == "ColumnDelete")
            {
                dataGridViewCheckout.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                var img = item.ImageList.Images[item.ImageIndex];

                reader = new BarcodeReader();
                var result = reader.Decode((Bitmap)img);
                DataTable dtb;
                if (result != null)
                {
                    string query = "SELECT * FROM SACH WHERE MaSach = " + result.Text;
                    dtb = Program.da.readDatathroughAdapter(query);

                    dataGridViewSearch.Rows.Clear();
                    dataGridViewSearch.Refresh();
                    foreach (DataRow row in dtb.Rows)
                    {
                        dataGridViewSearch.Rows.Add(row["MaSach"].ToString(), row["TenSach"].ToString(), row["GiaBan"].ToString()); ;
                        textBox1.Text = row["MaSach"].ToString();
                    }

                    if (selectingItem != item)
                    {
                        selectingItem = item;

                    }
                    else
                    {
                        //Insert this item into dataGridViewCheckout
                        foreach (DataRow row in dtb.Rows)
                        {
                            AddToCheckout(row);
                        }
                    }
                }

            }
        }
        string ToMoney(double m)
        {
            string t = m.ToString();
            int i = t.Length;

            while (i > 3)
            {
                t = t.Insert(i - 3, " ");
                i -= 3;
            }

            return t;
        }
        string ToMoney(string m)
        {
            string t = m;
            int i = t.Length;

            while (i > 3)
            {
                t = t.Insert(i - 3, " ");
                i -= 3;
            }

            return t;
        }
        void AddToCheckout(DataRow row)
        {
            string ID = row["MaSach"].ToString();
            foreach (DataGridViewRow r in dataGridViewCheckout.Rows)
            {
                if (ID.Equals(r.Cells["ColumnCheckoutID"].Value))
                {
                    int q = Convert.ToInt32(r.Cells["ColumnQuantity"].Value);
                    q++;
                    r.Cells["ColumnQuantity"].Value = q;
                    return;
                }

            }

            //dataGridViewCheckout.Rows.Add(ID, checkoutIndex.ToString(), row["TenSach"].ToString(), ToMoney(row["GiaBan"].ToString()), 1, ToMoney(row["GiaBan"].ToString()));
            dataGridViewCheckout.Rows.Add(ID, checkoutIndex.ToString(), row["TenSach"].ToString(), row["GiaBan"].ToString(), 1, row["GiaBan"].ToString());
            //dataGridViewCheckout.Rows.Add(ID, checkoutIndex.ToString(int, Int32Converter), row["TenSach"].ToString(), row["GiaBan"].ToString(), 1, row["GiaBan"].ToString());

            checkoutIndex++;
            //dataGridViewCheckout.Rows[0].Cells[1].Value = 1;
            dataGridViewCheckout_CellValueChanged(new DataGridView(), new DataGridViewCellEventArgs(0, 0));
        }
        void AddToCheckout(DataGridViewRow row)
        {
            string ID = row.Cells["ColumnSearchID"].Value.ToString();
            foreach (DataGridViewRow r in dataGridViewCheckout.Rows)
            {
                if (ID.Equals(r.Cells["ColumnCheckoutID"].Value))
                {
                    int q = Convert.ToInt32(r.Cells["ColumnQuantity"].Value);
                    q++;
                    r.Cells["ColumnQuantity"].Value = q;
                    return;
                }
            }

            dataGridViewCheckout.Rows.Add(ID, checkoutIndex.ToString(), row.Cells["ColumnSearchName"].Value.ToString(), row.Cells["ColumnSearchPrice"].Value.ToString(), 1, row.Cells["ColumnSearchPrice"].Value.ToString());
            checkoutIndex++;
            //dataGridViewCheckout.Rows[0].Cells[1].Value = 1;
            dataGridViewCheckout_CellValueChanged(new DataGridView(), new DataGridViewCellEventArgs(0, 0));
        }

        private void dataGridViewCheckout_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Chỉnh lại số lượng và giá tiền
            if (dataGridViewCheckout.Columns[e.ColumnIndex].Name == "ColumnQuantity")
            {
                int quantity = Convert.ToInt32(dataGridViewCheckout.Rows[e.RowIndex].Cells["ColumnQuantity"].Value);
                double price = Convert.ToDouble(dataGridViewCheckout.Rows[e.RowIndex].Cells["ColumnPrice"].Value);
                double total = (double)quantity * price;
                dataGridViewCheckout.Rows[e.RowIndex].Cells["ColumnTotal"].Value = total;
            }

            //Cập nhật tổng tiền
            double t = 0;
            try
            {
                foreach (DataGridViewRow r in dataGridViewCheckout.Rows)
                {
                    t += Convert.ToDouble(r.Cells["ColumnTotal"].Value);
                }
            }
            catch (Exception ex) { };

            totalMoney = t;
            //labelTotal.Text = totalMoney.ToString();
            labelTotal.Text = ToMoney(totalMoney);
        }

        private void txtGiven_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double given = Convert.ToDouble(txtGiven.Text);
                //Kiem tra dieu kien sau
                //....

                labelChange.Text = ToMoney((given - totalMoney));
            }  
            catch (Exception ex)
            {

            }
        }

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSearch.Columns[e.ColumnIndex].Name == "ColumnAdd")
            {
                AddToCheckout(dataGridViewSearch.Rows[e.RowIndex]);
            }
        }
    }
}
