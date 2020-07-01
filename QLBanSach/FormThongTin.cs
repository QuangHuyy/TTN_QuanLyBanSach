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

        private void Btnthemdsach_Click(object sender, EventArgs e)
        {
            string tendsach = texttendausach.Text;
            string matgchinh = textmatgchinh.Text;

            SqlCommand insertCommand = new SqlCommand("insert into " + "DAUSACH(tendsach,matgchinh) " + "values(@tendsach,@matgchinh)");
            insertCommand.Parameters.AddWithValue("@tendsach", tendsach);
            insertCommand.Parameters.AddWithValue("@matgchinh", matgchinh);
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

        private void Btnsuadsach_Click(object sender, EventArgs e)
        {
            string madsach = textmadsach.Text;
            string tendsach = texttendausach.Text;
            string matgchinh= textmatgchinh.Text;

            string query = "update DAUSACH set tendsach=N'" +
                 @tendsach + "' where madsach ='" + int.Parse(@madsach) + "'";

            SqlCommand update = new SqlCommand(query);
            int row = Program.da.executeQuery(update);

            string query1 = "update DAUSACH set matgchinh='" +
                 @matgchinh + "' where madsach ='" + int.Parse(@madsach) + "'";

            SqlCommand update1 = new SqlCommand(query1);
            int row1 = Program.da.executeQuery(update1);
            if (row != 0 && row1 != 0)
            {
                MessageBox.Show("thanh cong");

            }
            else
            {
                MessageBox.Show("khong thanh cong");
            }
        }

        private void Btnxoadsach_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ban co chac chan muon xoa k ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string query1 = "delete from DAUSACH where Madsach=N'" + int.Parse(textmadsach.Text) + "'";
                SqlCommand de = new SqlCommand(query1);
                int row1 = Program.da.executeQuery(de);
               // string query = "delete from TACGIA where Matg= '" + int.Parse(textmatg.Text) + "'";
               // SqlCommand delete = new SqlCommand(query);
               // int row = Program.da.executeQuery(delete);
                if (row1 != 0)
                {
                    MessageBox.Show("Ok");

                }
            }
        }

        private void Btntimkiemdsach_Click(object sender, EventArgs e)
        {
            DataTable dtUsers = new DataTable();
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();

            string query = "select * from DAUSACH where Tendsach=N'" + texttendausach.Text + "'";

            dtUsers = Program.da.readDatathroughAdapter(query);
            dataGridView2.DataSource = dtUsers;
        }

        private void Btnktratrung_Click(object sender, EventArgs e)
        {
            DataTable dtU = new DataTable();
            string query = "select tendsach from DAUSACH where Tendsach=N'" + texttendausach.Text + "'";
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

        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable dtUsers = new DataTable();
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();

            string query = "select * from DAUSACH where Matgchinh=N'" + int.Parse(textmatgchinh.Text) + "'";

            dtUsers = Program.da.readDatathroughAdapter(query);
            dataGridView2.DataSource = dtUsers;
        }
    }
}
