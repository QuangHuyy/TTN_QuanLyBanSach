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
    public partial class FormNgonNgu : Form
    {
        public FormNgonNgu()
        {
            InitializeComponent();
        }

        private void Btnthemngonngu_Click(object sender, EventArgs e)
        {
            string TenNN = textmann.Text;

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

        private void Btntimkiemngonngu_Click(object sender, EventArgs e)
        {
            DataTable dtUsers = new DataTable();
            dataGridViewngonngu.DataSource = null;
            dataGridViewngonngu.Refresh();

            string query = "select * from NGONNGU where TenNN='" + texttennn.Text + "'";

            dtUsers = Program.da.readDatathroughAdapter(query);
            dataGridViewngonngu.DataSource = dtUsers;
        }

        private void Btntrung_Click(object sender, EventArgs e)
        {
            string query = "select Ngonngu.Tennn from Ngonngu where Tennn='" + texttennn.Text + "'";
            SqlCommand de = new SqlCommand(query);
            int row1 = Program.da.executeQuery(de);
            if (row1 != 0)
            {
                MessageBox.Show("Trung du lieu!");

            }
        }
    }
}
