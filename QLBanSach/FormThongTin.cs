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

        private void Btnthemngonngu_Click(object sender, EventArgs e)
        {
            string TenNN = textmatg.Text;

            SqlCommand insertCommand = new SqlCommand("insert into " + "NGONNGU(TenNN) " + "values(@TenNN)");
            insertCommand.Parameters.AddWithValue("@TenNN", TenNN);
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
                 @TenTG + "' where MaTg ='" + int.Parse(@MaTG) + "'";
                
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

        private void Suangonngu_Click(object sender, EventArgs e)
        {
            string MaNN = textmann.Text;
            string TenNN = texttennn.Text;

            string query = "update NGONNGU set TenNN='" +
                 @TenNN + "' where MaNN ='" + int.Parse(@MaNN) + "'";

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

        private void Btnxoangonngu_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ban co chac chan muon xoa k ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string query1 = "delete from NGONNGU_SACH where MaNN='" + int.Parse(textmann.Text) + "'";
                SqlCommand de = new SqlCommand(query1);
                int row1 = Program.da.executeQuery(de);
                string query = "delete from NGONNGU where MaNN= '" + int.Parse(textmann.Text) + "'";
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
           
            string query = "select * from TACGIA where Matg='" + int.Parse(textmatg.Text) + "'";

            dtUsers= Program.da.readDatathroughAdapter(query);
            dataGridViewtacgia.DataSource = dtUsers;
           
        }

        private void Btntimkiemngonngu_Click(object sender, EventArgs e)
        {
            DataTable dtUsers = new DataTable();
            dataGridViewngonngu.DataSource = null;
            dataGridViewngonngu.Refresh();

            string query = "select * from NGONNGU where MaNN='" + int.Parse(textmann.Text) + "'";

            dtUsers = Program.da.readDatathroughAdapter(query);
            dataGridViewtacgia.DataSource = dtUsers;
        }
    }
}
