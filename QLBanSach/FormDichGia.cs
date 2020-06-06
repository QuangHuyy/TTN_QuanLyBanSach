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

namespace QLBanSach
{
    public partial class FormDichGia : Form
    {
        public FormDichGia()
        {
            InitializeComponent();
        }
        void loadDataDG()
        {
            DataTable table;
            dataGridViewDichGia.DataSource = null;
            dataGridViewDichGia.Refresh();

            string query = "select * from Dichgia";

            table = Program.da.readDatathroughAdapter(query);
            dataGridViewDichGia.DataSource = table;
        }
        private void FormDichGia_Load(object sender, EventArgs e)
        {

        }
  

        private void themDichGia_Click_1(object sender, EventArgs e)
        {
            SqlCommand kiemTraTrung = new SqlCommand("select * from DichGiaSach where TenDG='" + textTenDG.Text + "'");
            //  int row = Program.da.executeQuery(kiemTraTrung);
            int check = (int)kiemTraTrung.ExecuteScalar();
           
                if (check>0)
                {
                    MessageBox.Show("trung roi");
                    
                }
                else
                {
                    if (!textMaDG.Text.Equals(""))
                        MessageBox.Show("Khong duoc nhap ma dich gia!");
                    if (textTenDG.Text.Equals(""))
                        MessageBox.Show("Ban chua nhap ten dich gia!");
                    else
                    {
                         kiemTraTrung = new SqlCommand("insert into " + "DichGiaSach " + "values('" + textTenDG.Text + "')");
                        Program.da.executeQuery(kiemTraTrung);
                        MessageBox.Show("Them thanh cong!");
                        loadDataDG();
                    }
              
                    
            }
            //MessageBox.Show(+row + "");
            //    if (!textMaDG.Text.Equals(""))
            //        MessageBox.Show("Khong duoc nhap ma dich gia!");
            //    if (textTenDG.Text.Equals(""))
            //        MessageBox.Show("Ban chua nhap ten dich gia!");
            //    else
            //    {
            //        SqlCommand cm = new SqlCommand("insert into " + "DichGia " + "values('" + textTenDG.Text + "')");
            //        Program.da.executeQuery(cm);
            //        MessageBox.Show("Them thanh cong!");
            //        loadDataDG();
            //    }
          
        }

        private void suaDichGia_Click_1(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update DichGia set TenDG='" + textTenDG.Text + "' where MaDG ='" + int.Parse(textMaDG.Text) + "'");
            if (textMaDG.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ma can sua!");
            else
            {


                Program.da.executeQuery(update);


                MessageBox.Show("Sua thanh cong!");
                loadDataDG();
            }
        }

        private void xoaDichGia_Click_1(object sender, EventArgs e)
        {
            SqlCommand xoa = new SqlCommand("delete DichGia  where MaDG='" + textMaDG.Text + "'");
            if (textMaDG.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ma can xoa!");
            else
            {
                Program.da.executeQuery(xoa);

                MessageBox.Show("xoa thanh cong!");
                loadDataDG();
            }
        }

        private void timDichGia_Click_1(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            dataGridViewDichGia.DataSource = null;
            dataGridViewDichGia.Refresh();
            if (!textMaDG.Text.Equals(""))
            {
                string query = "select * from Dichgia where MaDG='" + int.Parse(textMaDG.Text) + "'";

                table = Program.da.readDatathroughAdapter(query);
                dataGridViewDichGia.DataSource = table;
            }
            else
            {
                string query = "select * from Dichgia where TenDG='" + textTenDG.Text + "'";

                table = Program.da.readDatathroughAdapter(query);
                dataGridViewDichGia.DataSource = table;
            }
        }

        private void hienThiDichGia_Click_1(object sender, EventArgs e)
        {
            textMaDG.Text = "";
            textTenDG.Text = "";
            loadDataDG();
        }

        private void dataGridViewDichGia_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewDichGia.CurrentRow.Index;
            textMaDG.Text = dataGridViewDichGia.Rows[i].Cells[0].Value.ToString();
            textTenDG.Text = dataGridViewDichGia.Rows[i].Cells[1].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
