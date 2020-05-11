using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanSach
{
    public partial class FormThongTin : Form
    {
        //DBAcess db = new DBAcess();
        public FormThongTin()
        {
            InitializeComponent();
        }

        private void Btnthemtacgia_Click(object sender, EventArgs e)
        {
            string TenTg = textmatg.Text;
            
            SqlCommand insertCommand = new SqlCommand("insert into " + "TACGIA(TenTg) " + "values(@TenTg)");
            insertCommand.Parameters.AddWithValue("@TenTg", TenTg);
            int row = Program.da.executeQuery(insertCommand);
            if (row == 1)
            {
                MessageBox.Show("Them thanh cong!");
               
            }
            else
            {
                MessageBox.Show("Failed....");
            }
           
        }

       
        private void Btnsuatacgia_Click(object sender, EventArgs e)
        {
            string MaTG = textmatg.Text;
            string TenTG = texttentg.Text;

            string query = "update TACGIA set TenTg='" +
                 @TenTG + "' where tenTg ='" + int.Parse(@MaTG) + "'";
                
            SqlCommand update = new SqlCommand(query);
            int row = Program.da.executeQuery(update);
            if (row != 0)
            {
                MessageBox.Show("thanh cong");
               
            }
            else
            {
                MessageBox.Show("khong thanh cong");
            }
        }

       

        private void Btnxoatacgia_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ban co chac chan muon xoa k ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string query1 = "delete from TACGIA_SACH where Matg='" + int.Parse(textmatg.Text) + "'";
                SqlCommand de = new SqlCommand(query1);
                int row1 = Program.da.executeQuery(de);
                string query = "delete from TACGIA where Matg= '" + int.Parse(textmatg.Text) + "'";
                SqlCommand delete = new SqlCommand(query);
                int row = Program.da.executeQuery(delete);
                if (row != 0)
                {
                    MessageBox.Show("Ok");
                   
                }
            }
        }

        private void Btntimkiemtacgia_Click(object sender, EventArgs e)
        {
            DataTable dtUsers = new DataTable();
            dataGridViewtacgia.DataSource = null;
            dataGridViewtacgia.Refresh();
           
            string query = "select * from TACGIA where Tentg='" + texttentg.Text + "'";

            dtUsers= Program.da.readDatathroughAdapter(query);
            dataGridViewtacgia.DataSource = dtUsers;
           
        }

        private void Btntrung_Click(object sender, EventArgs e)
        {
            DataTable dtU = new DataTable();
            string query = "select Tacgia.Tentg from TACGIA where Tentg='" + texttentg.Text + "'";
            // SqlCommand de = new SqlCommand(query);
            dtU = Program.da.readDatathroughAdapter(query);
            if (dtU.Rows.Count != 0)
            {
                MessageBox.Show("Trung du lieu!");

            }
            else
            {
                MessageBox.Show("Khong trung du lieu!");
            }
        }
    }
}
