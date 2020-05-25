using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Data.Odbc;
namespace QLBanSach
{
    public partial class FormNhapSach : Form
    {
        public FormNhapSach()
        {
            InitializeComponent();
            
            FillCombo("SELECT MaNXB,TenNXB FROM NHAXUATBAN", comboBoxNXB, "MaNXB", "TenNXB");

            comboBoxNXB.SelectedIndex = -1;
            FillCombo("SELECT MaSeries,TenSeries FROM Series", comboBoxSeries, "MaSeries", "TenSeries");
            comboBoxSeries.SelectedIndex = -1;
            loadDataSach();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void FormCapNhatSach_Load(object sender, EventArgs e)
        {

        }
        void loadDataSach()
        {
            //DataTable table = new DataTable();
            //dataGridViewSach.DataSource = null;
            //dataGridViewSach.Refresh();

            //string query = "select * from Sach";

            //table = Program.da.readDatathroughAdapter(query);
            //dataGridViewSach.DataSource = table;
            //
            DataTable table1 = new DataTable();
            dataGridViewSach.DataSource = null;
            dataGridViewSach.Refresh();

            string query1 = "select * from Sach";

            table1 = Program.da.readDatathroughAdapter(query1);
            dataGridViewSach.DataSource = table1;

        }
        private void FormDichGia_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

       
        private void DanhMuc_TLoai_Load(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into " + "Sach(TenSach,GiaBan,SoLuong,MaNXB,NamXB,MaSeries)  " + "values('" +(textBoxTenSach.Text) + "','" + int.Parse(textBoxGiaBan.Text) + "','" + int.Parse(textBoxSoLuong.Text) + "','" + int.Parse(comboBoxNXB.SelectedValue.ToString()) + "','" + int.Parse(textBoxNamXB.Text) + "','" + int.Parse(comboBoxSeries.SelectedValue.ToString()) + "')");

            if (!textBoxMaSach.Text.Equals(""))
                MessageBox.Show("Khong duoc nhap ma sach!");
            if (textBoxTenSach.Text.Equals("") || comboBoxNXB.Text.Equals("") || comboBoxSeries.Text.Equals("") || textBoxSoLuong.Text.Equals("") || textBoxGiaBan.Text.Equals("") || textBoxNamXB.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ten the loai hoac ma danh muc!");
            else
            {
                Program.da.executeQuery(command);
                MessageBox.Show("Them thanh cong sach!");
                loadDataSach();
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update Sach set TenSach=N'"  
                + textBoxTenSach.Text
                + "',GiaBan=" + double.Parse(textBoxGiaBan.Text) 
                + ",SoLuong=" + int.Parse(textBoxSoLuong.Text) 
                + ",MaNXB=" + int.Parse(comboBoxNXB.SelectedValue.ToString())
                + ",NamXB='" + (textBoxNamXB.Text) + "',MaSeries=" 
                + int.Parse(comboBoxSeries.SelectedValue.ToString()) 
                + " where MaSach =" + int.Parse(textBoxMaSach.Text) + "");
            if (textBoxMaSach.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ma can sua!");
            else
            {


                Program.da.executeQuery(update);


                MessageBox.Show("Sua thanh cong sach!");
                loadDataSach();
            }
        }

        private void dataGridViewSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewSach.CurrentRow.Index;
            textBoxMaSach.Text = dataGridViewSach.Rows[i].Cells[0].Value.ToString();
            textBoxTenSach.Text= dataGridViewSach.Rows[i].Cells[1].Value.ToString();
            comboBoxNXB.Text = dataGridViewSach.Rows[i].Cells[2].Value.ToString();
            textBoxSoLuong.Text = dataGridViewSach.Rows[i].Cells[3].Value.ToString();
            textBoxNamXB.Text = dataGridViewSach.Rows[i].Cells[4].Value.ToString();
            textBoxGiaBan.Text = dataGridViewSach.Rows[i].Cells[5].Value.ToString();
            comboBoxSeries.Text = dataGridViewSach.Rows[i].Cells[6].Value.ToString();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            SqlCommand xoa = new SqlCommand("delete SACH  where MaSach='" + textBoxMaSach.Text + "'");
            if (textBoxMaSach.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ma can xoa!");
            else
            {
                Program.da.executeQuery(xoa);

                MessageBox.Show("xoa thanh cong!");
                loadDataSach();
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            dataGridViewSach.DataSource = null;
            dataGridViewSach.Refresh();
            if (!textBoxMaSach.Text.Equals(""))
            {
                string query = "select * from Sach where MaSach='" + int.Parse(textBoxMaSach.Text) + "'";

                table = Program.da.readDatathroughAdapter(query);
                dataGridViewSach.DataSource = table;
            }
            else
            {
                string query = "select * from Sach where TenSach='" + textBoxTenSach.Text + "'";

                table = Program.da.readDatathroughAdapter(query);
                dataGridViewSach.DataSource = table;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxTenSach.Text = "";
            comboBoxNXB.Text = "";
            comboBoxSeries.Text = "";
            textBoxGiaBan.Text = "";
            textBoxSoLuong.Text = "";
            textBoxNamXB.Text = "";
            loadDataSach();
        }
    }
}
