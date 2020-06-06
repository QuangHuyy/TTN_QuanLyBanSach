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
        private static SqlConnection connection = new SqlConnection();

        private static SqlCommand cm;
        private static SqlDataAdapter adap = new SqlDataAdapter();
        DataTable table = new DataTable();
       // DataTable table2 = new DataTable();
        // private string strConnString;
       // public static string strConnString = "data source=DESKTOP-0CQQH02\\SQLEXPRESS; " + "Integrated Security=True ;" + "database=QuanLyBanSach";

        public FormDichGia()
        {
            InitializeComponent();
            FillCombo("SELECT MaDG,TenDG FROM DichGia", comboBox1, "MaDG", "TenDG");
            comboBox1.SelectedIndex = -1;
            loadDataDG();
        }
        void loadDataDG()
        {
            connection = new SqlConnection(DBAcess.strConnString);
            connection.Open();
            DataTable table;
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            string query = "select * from Dichgia";

            table = Program.da.readDatathroughAdapter(query);
            dataGridView1.DataSource = table;
        }
        private void FormDichGia_Load(object sender, EventArgs e)
        {
            FillCombo("SELECT MaDG,TenDG FROM DichGia", comboBox1, "MaDG", "TenDG");
            comboBox1.SelectedIndex = -1;
            loadDataDG();
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
           
            // conn.Open();

            SqlCommand cmd = new SqlCommand(sql);
            SqlDataAdapter da;//= new SqlDataAdapter(cmd,);

            //dataGridViewDichGia.DataSource = table;
            DataTable table = new DataTable(); table = Program.da.readDatathroughAdapter(sql);
            //  da.Fill(table);
            // da.Dispose();
            cbo.Refresh();
            cbo.DataSource = table;
            table = Program.da.readDatathroughAdapter(sql);
            cbo.DataSource = table;

            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
           

        }

        private void themDichGia_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into DichGia values (N'" + comboBox1.Text + "')");
            string query = "select * from  DichGia where TenDG=N'" + comboBox1.Text + "'";
            DataTable dtU = new DataTable();


            dtU = Program.da.readDatathroughAdapter(query);
            if (dtU.Rows.Count != 0)
            {
                MessageBox.Show("Trung du lieu, xin nhap lai!");

            }
            else
            {
                if (!textBox1.Text.Equals(""))
                    MessageBox.Show("Khong duoc nhap ma dich gia!");
                if (comboBox1.Text.Equals(""))
                    MessageBox.Show("Ban chua nhap ten dich gia!");
                else
                {
                    Program.da.executeQuery(command);
                    MessageBox.Show("Them dich gia thanh cong!");
                    loadDataDG();
                }


            }
         
        
            //  int row = Program.da.executeQuery(kiemTraTrung);



        }

        private void FormDichGia_Load_1(object sender, EventArgs e)
        {
            FillCombo("SELECT MaDG,TenDG FROM DichGia", comboBox1, "MaDG", "TenDG");
            comboBox1.SelectedIndex = -1;
            loadDataDG();
        }

        private void textBoxThem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into DichGia values (N'" + comboBox1.Text + "')");
            string query = "select * from  DichGia where TenDG=N'" + comboBox1.Text + "'";
            DataTable dtU = new DataTable();


            dtU = Program.da.readDatathroughAdapter(query);
            if (dtU.Rows.Count != 0)
            {
                MessageBox.Show("Trung du lieu, xin nhap lai!");

            }
            else
            {
                if (!textBox1.Text.Equals(""))
                    MessageBox.Show("Khong duoc nhap ma dich gia!");
                if (comboBox1.Text.Equals(""))
                    MessageBox.Show("Ban chua nhap ten dich gia!");
                else
                {
                    Program.da.executeQuery(command);
                    MessageBox.Show("Them dich gia thanh cong!");
                    loadDataDG();
                }


            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update DichGia set TenDG=N'" + comboBox1.Text + "' where MaDG ='" + int.Parse(textBox1.Text) + "'");
            if (textBox1.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ma can sua!");
            else
            {


                Program.da.executeQuery(update);


                MessageBox.Show("Sua thanh cong!");
                loadDataDG();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ten dich gia can xoa!");
            else
            {

                //SqlCommand xoa1 = new SqlCommand("delete DichGia_Sach  where MaDG='" + int.Parse(textBox1.Text) + "'");
                //SqlCommand xoa = new SqlCommand("delete DichGia  where MaDG='" + int.Parse(textBox1.Text) + "'");
                //Program.da.executeQuery(xoa1);
                //Program.da.executeQuery(xoa);

                //MessageBox.Show("xoa thanh cong!");
                cm = connection.CreateCommand();

                cm.CommandText = "XoaDichGia";
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@TenDG", (comboBox1.Text)));



                cm.ExecuteNonQuery();

                MessageBox.Show("Xóa Dich gia thành công");
                
                loadDataDG();
            }
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            if (!comboBox1.Text.Equals(""))
            {
                string query = "select * from Dichgia where TenDG=N'" + (comboBox1.Text) + "'";

                table = Program.da.readDatathroughAdapter(query);
                dataGridView1.DataSource = table;
                
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên dịch giả cần tìm");
            }
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            loadDataDG();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
         
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            FillCombo("SELECT MaDG,TenDG FROM DichGia", comboBox1, "MaDG", "TenDG");
            comboBox1.SelectedIndex = -1;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            
        }
    }
}
