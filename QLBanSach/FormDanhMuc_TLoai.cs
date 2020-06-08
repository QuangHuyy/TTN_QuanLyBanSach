using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLBanSach
{
    public partial class FormDanhMuc_TLoai : Form
    {
        private string DM,TL;
        //DM = comboBoxDM_TL.Text;
        private static SqlConnection connection = new SqlConnection();

        private static SqlCommand cm;
        private static SqlDataAdapter adap = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
       // private string strConnString;
        //public static string strConnString = "data source=DESKTOP-0CQQH02\\SQLEXPRESS; " + "Integrated Security=True ;" + "database=QuanLyBanSach";

        public FormDanhMuc_TLoai()
        {
           // DM = comboBoxDM_TL.Text;
            InitializeComponent();
            FillCombo("SELECT MaDM,TenDM FROM DANHMUCSACH", comboBoxTenDM, "MaDM", "TenDM");
            comboBoxTenDM.SelectedIndex = -1;
            FillCombo("SELECT MaDM,TenDM FROM DANHMUCSACH", comboBoxDM_TL, "MaDM", "TenDM");

            comboBoxDM_TL.SelectedIndex = -1;
            FillCombo("SELECT MaTL,TenTL FROM THELOAI", comboBoxTenTL, "MaTL", "TenTL");
            comboBoxTenTL.SelectedIndex = -1;
            loadDataDM();
            loadDataTL();
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

            SqlCommand cmd = new SqlCommand(sql);
            SqlDataAdapter da;//= new SqlDataAdapter(cmd,);
            
            //dataGridViewDichGia.DataSource = table;
            DataTable table = new DataTable();table = Program.da.readDatathroughAdapter(sql);
          //  da.Fill(table);
           // da.Dispose();
            cbo.Refresh();
            cbo.DataSource = table;
            table = Program.da.readDatathroughAdapter(sql);
            cbo.DataSource = table;

            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị


        } 

        private void buttonXoaDM_Click(object sender, EventArgs e)
        {
            //SqlCommand xoa = new SqlCommand("delete DanhMucSach  where MaDM='" + textBoxMaDM.Text + "'");
            //SqlCommand xoa1 = new SqlCommand("delete TheLoai  where MaDM='" + textBoxMaDM.Text + "'");
           // SqlCommand xoa2 = new SqlCommand("delete TheLoai,DanhMucSach,TheLoai_Sach  where TheLoai_Sach.MaTL=TheLoai.MaTL and DanhMucSach.MaDM=TheLoai.MaDM and DanhMucSach.MaDM=N'" + textBoxMaDM.Text + "'");
            if (textBoxMaDM.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ma can xoa!");
            else
            {
                cm = connection.CreateCommand();

                cm.CommandText = "XoaDanhMuc";
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@MaDM", (textBoxMaDM.Text)));



                cm.ExecuteNonQuery();

                MessageBox.Show("Xóa Danh mục thành công");
                loadDataDM();
            }

            

          
        }

        private void buttonThemDM_Click(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand("insert into DanhMucSach values (N'" + comboBoxTenDM.Text + "')");
            string query = "select * from  DanhMucSach where TenDM=N'" + comboBoxTenDM.Text + "'";
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
            SqlCommand update = new SqlCommand("update DanhMucSach set TenDM=N'" + comboBoxTenDM.Text + "' where MaDM ='" + int.Parse(textBoxMaDM.Text) + "'");
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
            if (comboBoxTenDM.Text.Equals(""))
            {
                //string query = "select * from DanhMucSach where MaDM='" + int.Parse(textBoxMaDM.Text) + "'";

                //table = Program.da.readDatathroughAdapter(query);
                //dataGridViewDanhMuc.DataSource = table;
                MessageBox.Show("Bạn chưa nhập tên danh mục cần tìm");
            }
            else
            {
                string query = "select * from DanhMucSach where TenDM=N'" + comboBoxTenDM.Text + "'";

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
            DM = comboBoxDM_TL.Text;
            TL = comboBoxTenTL.Text;
            connection = new SqlConnection(DBAcess.strConnString);
            connection.Open();
            DataTable table1 = new DataTable();
            dataGridViewTheLoai.DataSource = null;
            dataGridViewTheLoai.Refresh();

            string query1 = "select * from ShowTheLoai";

            table1 = Program.da.readDatathroughAdapter(query1);
            dataGridViewTheLoai.DataSource = table1;
           
        }
        private void buttonThemTL_Click(object sender, EventArgs e)
        {
           // SqlCommand command = new SqlCommand("insert into " + "TheLoai " + "values('" + int.Parse(comboBoxDM_TL.ValueMember.ToString()) + "',N'" + (comboBoxTenTL.Text) + "')");

            
            //SqlCommand command = new SqlCommand("insert into DanhMucSach values (N'" + comboBoxTenDM.Text + "')");
            string query = "select * from  TheLoai,DanhMucSach where TenTL=N'" + comboBoxTenTL.Text + "' and TenDM=N'"+(comboBoxDM_TL.Text.ToString())+"' and DanhMucSach.MaDM=TheLoai.maDM";
            DataTable dtU = new DataTable();
            // MessageBox.Show("ma danh muc: "+comboBoxDM_TL.ValueMember.ToString() );
            //MessageBox.Show("ten danh muc: " + comboBoxDM_TL.DisplayMember.ToString());
            // SqlCommand de = new SqlCommand(query);
            dtU = Program.da.readDatathroughAdapter(query);
            if (!textBoxMaTL.Text.Equals(""))
                MessageBox.Show("Khong duoc nhap ma the loai!");
            if (comboBoxTenTL.Text.Equals("") || comboBoxDM_TL.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ten the loai hoac ma danh muc!");
            else
            {
                if (dtU.Rows.Count != 0)
                {
                    MessageBox.Show("Trung du lieu, xin nhap lai!");

                }
                else
                {
                    //MessageBox.Show("ok");
                    cm = connection.CreateCommand();

                    cm.CommandText = "ThemTheLoai";
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.Add(new SqlParameter("@TenTL", (comboBoxTenTL.Text)));
                    //MessageBox.Show("tên thể loại sách:" + comboBoxTenTL.Text);
                    cm.Parameters.Add(new SqlParameter("@TenDM", comboBoxDM_TL.Text));
                    //MessageBox.Show("tên danh mục sách: " + comboBoxDM_TL.Text);
                    

                    cm.ExecuteNonQuery();

                    MessageBox.Show("Thêm thể loại thành công");

                    loadDataTL();
                }
            }
            //else
            //{
          
            //    else
            //    {
            //        Program.da.executeQuery(command);
            //        MessageBox.Show("Them thanh cong the loai!");
            //        loadDataTL();
            //    }

            //}

        }

        private void buttonSuaTL_Click(object sender, EventArgs e)
        {
           
            SqlCommand update = new SqlCommand("update TheLoai set MaDM='" + int.Parse(comboBoxDM_TL.SelectedValue.ToString()) + "',TenTL=N'" + comboBoxTenTL.SelectedValue.ToString() + "' where MaTL ='" + int.Parse(textBoxMaTL.Text) + "'");
            if (textBoxMaTL.Text.Equals(""))
                MessageBox.Show("Ban chua nhap ma can sua!");
            else
            {


                cm = connection.CreateCommand();

                cm.CommandText = "SuaTheLoai";
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@TenTL", (comboBoxTenTL.Text)));
               //  MessageBox.Show("tên thể loại mới :" + comboBoxTenTL.Text);
                cm.Parameters.Add(new SqlParameter("@TenTL0", TL));
               //  MessageBox.Show("tên thể loại cũ:" + TL);
                cm.Parameters.Add(new SqlParameter("@TenDM", comboBoxDM_TL.Text));
                // MessageBox.Show("tên danh mục mới: " + comboBoxDM_TL.Text);
                cm.Parameters.Add(new SqlParameter("@TenDM0", DM));
                //MessageBox.Show("tên danh mục cũ: " + DM);

                cm.ExecuteNonQuery();

                MessageBox.Show("Sửa thể loại thành công");

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
            dataGridViewTheLoai.DataSource = null;
            dataGridViewTheLoai.Refresh();
            //if (!textBoxMaTL.Text.Equals(""))
            //{
            //    string query = "select * from TheLoai where MaTL='" + int.Parse(textBoxMaTL.Text) + "'";

            //    table = Program.da.readDatathroughAdapter(query);
            //    dataGridViewTheLoai.DataSource = table;
            //}
            //else
            //{
                string query = "select * from ShowTheLoai where TenTL=N'" + comboBoxTenTL.Text + "'";

                table = Program.da.readDatathroughAdapter(query);
                dataGridViewTheLoai.DataSource = table;
            //}
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
            comboBoxTenDM.Text= dataGridViewDanhMuc.Rows[i].Cells[1].Value.ToString();
        }

        private void dataGridViewTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DM = comboBoxDM_TL.Text; TL = comboBoxTenTL.Text;
            int i;
            i = dataGridViewTheLoai.CurrentRow.Index;
            textBoxMaTL.Text = dataGridViewTheLoai.Rows[i].Cells[0].Value.ToString();
            comboBoxDM_TL.Text = dataGridViewTheLoai.Rows[i].Cells[2].Value.ToString();
            comboBoxTenTL.Text = dataGridViewTheLoai.Rows[i].Cells[1].Value.ToString();
        }

        private void DanhMuc_TLoai_Load(object sender, EventArgs e)
        {
            DM = comboBoxDM_TL.Text; TL = comboBoxTenTL.Text;
            FillCombo("SELECT MaDM,TenDM FROM DANHMUCSACH", comboBoxTenDM, "MaDM", "TenDM");
            comboBoxTenDM.SelectedIndex = -1;
            FillCombo("SELECT MaDM,TenDM FROM DANHMUCSACH", comboBoxDM_TL, "MaDM", "TenDM");

            comboBoxDM_TL.SelectedIndex = -1;
            FillCombo("SELECT MaTL,TenTL FROM THELOAI", comboBoxTenTL, "MaTL", "TenTL");
            comboBoxTenTL.SelectedIndex = -1;
            loadDataDM();
            loadDataTL();
        }
        ////
    }
}

