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
using System.Data.SqlClient;
using System.Data.Odbc;
namespace QLBanSach
{
    public partial class FormNhapSach : Form
    {
        private string DM,TL,DG,TG,NN,DS,NXB,DauSach;
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand cm;
        private static SqlDataAdapter adap = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        //public static string strConnString = "data source=DESKTOP-E06EJ47\\SQLEXPRESS01; " + "Integrated Security=SSPI ;" + "database=QuanLyBanSach";
        //Data Source = DESKTOP - 0CQQH02\SQLEXPRESS;Initial Catalog = QuanLyBanSach; Integrated Security = True
        //public static string strConnString = "data source=DESKTOP-MVRA3GT\\SQLEXPRESS; " + "Integrated Security=SSPI ;" + "database=QuanLyBanSach";
       // public static string strConnString = "data source=DESKTOP-0CQQH02\\SQLEXPRESS; " + "Integrated Security=True ;" + "database=QuanLyBanSach";
        public FormNhapSach()
        {
            InitializeComponent();

            FillCombo("SELECT MaNXB,TenNXB FROM NHAXUATBAN", comboBoxNXB, "MaNXB", "TenNXB");

            comboBoxNXB.SelectedIndex = -1;
            //FillCombo("SELECT MaSeries,TenSeries FROM Series", comboBoxSeries, "MaSeries", "TenSeries");
            //comboBoxSeries.SelectedIndex = -1;
            FillCombo("SELECT MaDM,TenDM FROM DanhMucSach", comboBoxDanhMuc, "MaDM", "TenDM");
            comboBoxDanhMuc.SelectedIndex = -1;
            FillCombo("SELECT MaTL,TenTL FROM TheLoai", comboBoxTheLoai, "MaTL", "TenTL");
            comboBoxTheLoai.SelectedIndex = -1;
            FillCombo("SELECT MaDG,TenDG FROM DichGia", comboBoxDichGia, "MaDG", "TenDG");
            comboBoxDichGia.SelectedIndex = -1;
            FillCombo("SELECT MaTG,TenTG FROM TacGia", comboBoxTacGia, "MaTG", "TenTG");
            comboBoxTacGia.SelectedIndex = -1;
            FillCombo("SELECT MaNN,TenNN FROM NgonNgu", comboBoxNgonNgu, "MaNN", "TenNN");
            comboBoxNgonNgu.SelectedIndex = -1;
            FillCombo("SELECT MaDSach,TenDSach FROM DauSach", comboBoxDauSach, "MaDSach", "TenDSach");
            comboBoxDauSach.SelectedIndex = -1;
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
            //NN = comboBoxNgonNgu.Text;
            DM = comboBoxDanhMuc.Text;
            TL = comboBoxTheLoai.Text;
            DG = comboBoxDichGia.Text;
            TG = comboBoxTacGia.Text;
            //NN = comboBoxNgonNgu.Text;
            DS = comboBoxDauSach.Text;
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
            connection = new SqlConnection(DBAcess.strConnString);
            connection.Open();
            DataTable table1 = new DataTable();
            dataGridViewSach.DataSource = null;
            dataGridViewSach.Refresh();

            // string query1 = "select Sach.MaSach,TenSach,GiaBan,SoLuong, NHAXUATBAN.TenNXB,NamXB,Sach.Tap,NGONNGU.TenNN,DICHGIA.TenDG,TACGIA.TenTG,DANHMUCSACH.TenDM,THELOAI.TenTL  from Sach, DichGia, DICHGIA_SACH, TACGIA, TACGIA_SACH, NGONNGU, NGONNGU_SACH, DANHMUCSACH, THELOAI, THELOAI_SACH, NHAXUATBAN where Sach.MaSach = DICHGIA_SACH.MaSach and Sach.MaSach = TACGIA_SACH.MaSach and Sach.MaSach = NGONNGU_SACH.MaSach and THELOAI_SACH.MaSach = SACH.MaSach and DICHGIA_SACH.MaDG = DICHGIA.MaDG and TACGIA_SACH.MaTG = TACGIA.MaTG and NGONNGU_SACH.MaNN = NGONNGU.MaNN and THELOAI_SACH.MaTL = THELOAI.MaTL and DANHMUCSACH.MaDM = THELOAI.MaDM and Sach.MaNXB = NHAXUATBAN.MaNXB  and DICHGIA_SACH.MaSach = TACGIA_SACH.MaSach and DICHGIA_SACH.MaSach = NGONNGU_SACH.MaSach and DICHGIA_SACH.MaSach = THELOAI_SACH.MaSach and TACGIA_SACH.MaSach = NGONNGU_SACH.MaSach and TACGIA_SACH.MaSach = THELOAI_SACH.MaSach and NGONNGU_SACH.MaSach = THELOAI_SACH.MaSach";
            string query1 = "select * from Book";
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
            //SqlCommand command = new SqlCommand("insert into " + "Sach(TenSach,GiaBan,SoLuong,MaNXB,NamXB,MaSeries)  " + "values('" +(textBoxTenSach.Text) + "','" + int.Parse(textBoxGiaBan.Text) + "','" + int.Parse(textBoxSoLuong.Text) + "','" + int.Parse(comboBoxNXB.SelectedValue.ToString()) + "','" + int.Parse(textBoxNamXB.Text) + "','" + int.Parse(comboBoxSeries.SelectedValue.ToString()) + "')");

            //if (!textBoxMaSach.Text.Equals(""))
            //    MessageBox.Show("Khong duoc nhap ma sach!");
            //if (textBoxTenSach.Text.Equals("") || comboBoxNXB.Text.Equals("") || comboBoxSeries.Text.Equals("") || textBoxSoLuong.Text.Equals("") || textBoxGiaBan.Text.Equals("") || textBoxNamXB.Text.Equals(""))
            //    MessageBox.Show("Ban chua nhap ten the loai hoac ma danh muc!");
            //else
            //{
            //    Program.da.executeQuery(command);
            //    MessageBox.Show("Them thanh cong sach!");
            //    loadDataSach();
            //}

            //SqlCommand command = new SqlCommand("insert into DanhMucSach values (N'" + comboBoxTenDM.Text + "')");
            string query = "select * from  Book where TenSach=N'" + textBoxTenSach.Text + 
                "' and GiaBan='"+int.Parse(textBoxGiaBan.Text)+
                "' and SoLuong ='"+int.Parse(textBoxSoLuong.Text)+
                "'and NamXB=N'" + (textBoxNamXB.Text) +
                "' and NXB=N'" + (comboBoxNXB.Text) +
                "' and Tap=N'" + (textBoxTap.Text) +
                "' and NgonNgu=N'" + (comboBoxNgonNgu.Text) +
                "' and TacGiaChinh=N'" + (comboBoxTacGia.Text) +
                "' and DichGia=N'" + (comboBoxDichGia.Text) +
                "' and TheLoai=N'" + (comboBoxTheLoai.Text) +
                "' and DanhMuc=N'" + (comboBoxDanhMuc.Text) +
                "' and DauSach=N'" + (comboBoxDauSach.Text)+"'  ";
            DataTable dtU = new DataTable();
            
           // SqlCommand de = new SqlCommand(query);
            dtU = Program.da.readDatathroughAdapter(query);
            if (dtU.Rows.Count != 0)
            {
                MessageBox.Show("Trung du lieu, xin nhap lai!");

            }
            else
            {
                if (!textBoxMaSach.Text.Equals(""))
                {
                    MessageBox.Show("Khong can nhap ma sach");
                }
                else
                {
                    if (textBoxTenSach.Text.Equals("") | textBoxGiaBan.Text.Equals("") | textBoxSoLuong.Text.Equals("") | textBoxNamXB.Text.Equals("") | textBoxTap.Text.Equals("") | comboBoxNXB.Text.Equals("") | comboBoxDanhMuc.Text.Equals("") | comboBoxTheLoai.Text.Equals("") | comboBoxTacGia.Text.Equals("") | comboBoxDichGia.Text.Equals("") | comboBoxDauSach.Text.Equals("") | comboBoxNgonNgu.Text.Equals(""))
                    {
                        MessageBox.Show("Bạn nhập thiếu thông tin");

                    }
                    else
                    {
                        cm = connection.CreateCommand();

                        cm.CommandText = "ThemSach";
                        cm.CommandType = CommandType.StoredProcedure;

                        cm.Parameters.Add(new SqlParameter("@TenSach", textBoxTenSach.Text));
                        cm.Parameters.Add(new SqlParameter("@GiaBan", int.Parse(textBoxGiaBan.Text)));
                        cm.Parameters.Add(new SqlParameter("@SoLuong", int.Parse(textBoxSoLuong.Text)));
                        cm.Parameters.Add(new SqlParameter("@NXB", comboBoxNXB.Text));
                        cm.Parameters.Add(new SqlParameter("@NamXB", textBoxNamXB.Text));
                        cm.Parameters.Add(new SqlParameter("@Tap", textBoxTap.Text));
                        cm.Parameters.Add(new SqlParameter("@DG", comboBoxDichGia.Text));
                        cm.Parameters.Add(new SqlParameter("@DM", comboBoxDanhMuc.Text));
                        cm.Parameters.Add(new SqlParameter("@NN", comboBoxNgonNgu.Text));
                        //cm.Parameters.Add(new SqlParameter("@NN0", comboBoxNgonNgu.Text));
                        cm.Parameters.Add(new SqlParameter("@TL", comboBoxTheLoai.Text));

                        cm.Parameters.Add(new SqlParameter("@TG", comboBoxTacGia.Text));
                        cm.Parameters.Add(new SqlParameter("@DauSach", comboBoxDauSach.Text));
                        //cm.Parameters.Add(new SqlParameter("@DauSach0", comboBoxDauSach.Text));
                        //cmd1.ExecuteNonQuery();
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Thêm sách mới thành công");

                        loadDataSach();
                    }
                }

            }




        }

        private void textBoxMaSach_Click(object sender, EventArgs e)
        {
            NN = comboBoxNgonNgu.Text;
            DM = comboBoxDanhMuc.Text;
            TL = comboBoxTheLoai.Text;
            DG = comboBoxDichGia.Text;
            TG = comboBoxTacGia.Text;
            //NN = comboBoxNgonNgu.Text;
            DS = comboBoxDauSach.Text;
        }

        private void buttonSua_Click(object sender, EventArgs e)
    {
            //SqlCommand update = new SqlCommand("update Sach set TenSach=N'"
            //    + textBoxTenSach.Text
            //    + "',GiaBan=" + double.Parse(textBoxGiaBan.Text)
            //    + ",SoLuong=" + int.Parse(textBoxSoLuong.Text)
            //    + ",MaNXB=" + int.Parse(comboBoxNXB.SelectedValue.ToString())
            //    + ",NamXB='" + (textBoxNamXB.Text) + "',Tap='"
            //    + (textBoxTap.Text) + "'"
            //    + " where MaSach =" + int.Parse(textBoxMaSach.Text) + "");
            //if (textBoxMaSach.Text.Equals(""))
            //    MessageBox.Show("Ban chua nhap ma can sua!");
            //else
            //{


            //    Program.da.executeQuery(update);


            //    MessageBox.Show("Sua thanh cong sach!");
            //    loadDataSach();
            //}
           // MessageBox.Show(NXB);
            cm = connection.CreateCommand();

            cm.CommandText = "SuaSach";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add(new SqlParameter("@MaS", int.Parse(textBoxMaSach.Text)));
            cm.Parameters.Add(new SqlParameter("@TenSach", textBoxTenSach.Text));
            cm.Parameters.Add(new SqlParameter("@GiaBan", int.Parse(textBoxGiaBan.Text)));
            cm.Parameters.Add(new SqlParameter("@SoLuong", int.Parse(textBoxSoLuong.Text)));
   
            cm.Parameters.Add(new SqlParameter("@NXB", comboBoxNXB.Text));
            cm.Parameters.Add(new SqlParameter("@NXB0", NXB));
            cm.Parameters.Add(new SqlParameter("@NamXB", textBoxNamXB.Text));
            cm.Parameters.Add(new SqlParameter("@Tap", textBoxTap.Text));
            cm.Parameters.Add(new SqlParameter("@NN", comboBoxNgonNgu.Text));
            cm.Parameters.Add(new SqlParameter("@NN0", NN));
            
         
            cm.Parameters.Add(new SqlParameter("@DG", comboBoxDichGia.Text));
            cm.Parameters.Add(new SqlParameter("@DG0", DG));
            cm.Parameters.Add(new SqlParameter("@DM", comboBoxDanhMuc.Text));
            cm.Parameters.Add(new SqlParameter("@DM0", DM));
            cm.Parameters.Add(new SqlParameter("@TL", comboBoxTheLoai.Text));
            cm.Parameters.Add(new SqlParameter("@TL0", TL));
            cm.Parameters.Add(new SqlParameter("@TG", comboBoxTacGia.Text));
            cm.Parameters.Add(new SqlParameter("@TG0", TG));
            cm.Parameters.Add(new SqlParameter("@DauSach", comboBoxDauSach.Text));
            cm.Parameters.Add(new SqlParameter("@DauSach0", DS));
      
            cm.ExecuteNonQuery();
           
            MessageBox.Show("Sửa thành công");
           
            loadDataSach();
        }

    private void dataGridViewSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        int i;
        i = dataGridViewSach.CurrentRow.Index;
        textBoxMaSach.Text = dataGridViewSach.Rows[i].Cells[0].Value.ToString();
        textBoxTenSach.Text = dataGridViewSach.Rows[i].Cells[1].Value.ToString();
        textBoxGiaBan.Text = dataGridViewSach.Rows[i].Cells[2].Value.ToString();
        textBoxSoLuong.Text = dataGridViewSach.Rows[i].Cells[3].Value.ToString();
        comboBoxNXB.Text = dataGridViewSach.Rows[i].Cells[4].Value.ToString();
        textBoxNamXB.Text = dataGridViewSach.Rows[i].Cells[5].Value.ToString();
        textBoxTap.Text = dataGridViewSach.Rows[i].Cells[6].Value.ToString();
        comboBoxNgonNgu.Text = dataGridViewSach.Rows[i].Cells[7].Value.ToString();
        comboBoxDichGia.Text = dataGridViewSach.Rows[i].Cells[8].Value.ToString();
        comboBoxTacGia.Text = dataGridViewSach.Rows[i].Cells[12].Value.ToString();
        comboBoxTheLoai.Text = dataGridViewSach.Rows[i].Cells[9].Value.ToString();
          //  comboBoxDichGia.Text = dataGridViewSach.Rows[i].Cells[10].Value.ToString();
            comboBoxDanhMuc.Text = dataGridViewSach.Rows[i].Cells[10].Value.ToString();
            comboBoxDauSach.Text = dataGridViewSach.Rows[i].Cells[11].Value.ToString();
            NN = comboBoxNgonNgu.Text;
            DM = comboBoxDanhMuc.Text;
            TL = comboBoxTheLoai.Text;
            DG = comboBoxDichGia.Text;
            TG = comboBoxTacGia.Text;
           
            DS = comboBoxDauSach.Text;
            NXB = comboBoxNXB.Text;
        }

    private void buttonXoa_Click(object sender, EventArgs e)
    {
            //SqlCommand xoa = new SqlCommand("delete SACH  where MaSach='" + textBoxMaSach.Text + "'");
            //if (textBoxMaSach.Text.Equals(""))
            //    MessageBox.Show("Ban chua nhap ma can xoa!");
            //else
            //{
            //    Program.da.executeQuery(xoa);

            //    MessageBox.Show("xoa thanh cong!");
            //    loadDataSach();
            //}
            if (textBoxMaSach.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập mã sách hoặc cần xóa");
            }
            else
            {
                cm = connection.CreateCommand();

                cm.CommandText = "XoaSach";
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@MaSach", int.Parse(textBoxMaSach.Text)));
                cm.Parameters.Add(new SqlParameter("@TenSach", textBoxTenSach.Text));


                cm.ExecuteNonQuery();

                MessageBox.Show("Xóa sách thành công");

                loadDataSach();
            }
          
        }

    private void buttonTimKiem_Click(object sender, EventArgs e)
    {
            //DataTable table = new DataTable();
            //dataGridViewSach.DataSource = null;
            //dataGridViewSach.Refresh();
            //if (!textBoxMaSach.Text.Equals(""))
            //{
            //    string query = "select * from Sach where MaSach='" + int.Parse(textBoxMaSach.Text) + "'";

            //    table = Program.da.readDatathroughAdapter(query);
            //    dataGridViewSach.DataSource = table;
            //}
            //else
            //{
            //    string query = "select * from Sach where TenSach='" + textBoxTenSach.Text + "'";

            //    table = Program.da.readDatathroughAdapter(query);
            //    dataGridViewSach.DataSource = table;
            //}
            connection = new SqlConnection(DBAcess.strConnString);
            connection.Open();
            DataTable table1 = new DataTable();
            dataGridViewSach.DataSource = null;
            dataGridViewSach.Refresh();

            // string query1 = "select Sach.MaSach,TenSach,GiaBan,SoLuong, NHAXUATBAN.TenNXB,NamXB,Sach.Tap,NGONNGU.TenNN,DICHGIA.TenDG,TACGIA.TenTG,DANHMUCSACH.TenDM,THELOAI.TenTL  from Sach, DichGia, DICHGIA_SACH, TACGIA, TACGIA_SACH, NGONNGU, NGONNGU_SACH, DANHMUCSACH, THELOAI, THELOAI_SACH, NHAXUATBAN where Sach.MaSach = DICHGIA_SACH.MaSach and Sach.MaSach = TACGIA_SACH.MaSach and Sach.MaSach = NGONNGU_SACH.MaSach and THELOAI_SACH.MaSach = SACH.MaSach and DICHGIA_SACH.MaDG = DICHGIA.MaDG and TACGIA_SACH.MaTG = TACGIA.MaTG and NGONNGU_SACH.MaNN = NGONNGU.MaNN and THELOAI_SACH.MaTL = THELOAI.MaTL and DANHMUCSACH.MaDM = THELOAI.MaDM and Sach.MaNXB = NHAXUATBAN.MaNXB  and DICHGIA_SACH.MaSach = TACGIA_SACH.MaSach and DICHGIA_SACH.MaSach = NGONNGU_SACH.MaSach and DICHGIA_SACH.MaSach = THELOAI_SACH.MaSach and TACGIA_SACH.MaSach = NGONNGU_SACH.MaSach and TACGIA_SACH.MaSach = THELOAI_SACH.MaSach and NGONNGU_SACH.MaSach = THELOAI_SACH.MaSach";
            if(textBoxTenSach.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tên sách cần tìm ");
            }
            else
            {
                string query1 = "select * from Book where TenSach=N'" + textBoxTenSach.Text + "' "; //or MaSach = '"+int.Parse(textBoxMaSach.Text)+"'
                table1 = Program.da.readDatathroughAdapter(query1);

                //string query2 = "select * from Book where  =N'" + textBoxTenSach.Text + "'";
                //table1 = Program.da.readDatathroughAdapter(query2);
                // dataGridViewSach.DataSource = table1;TenSach

                dataGridViewSach.DataSource = table1;
            }
            

        }

        private void buttonReset_Click(object sender, EventArgs e)
    {
        textBoxTenSach.Text = "";
        comboBoxNXB.Text = "";
        textBoxTap.Text = "";
        textBoxGiaBan.Text = "";
        textBoxSoLuong.Text = "";
        textBoxNamXB.Text = "";
        loadDataSach();
    }
    }
}
//public static string ma, tencn, tennv, ngay1, ngay2, ngayhn;
//public static DateTime tg;
//SqlConnection connection;
//SqlCommand command, command1, cmd, cmd1;
//string str = @"Data Source=DESKTOP-0CQQH02\SQLEXPRESS;Initial Catalog=QLCH_TRASUA;Integrated Security=True";
//SqlDataAdapter adapter = new SqlDataAdapter();
//SqlDataAdapter adap = new SqlDataAdapter();
//SqlDataAdapter adap1 = new SqlDataAdapter();

////
//cmd1 = connection.CreateCommand();
//            cmd1.CommandText = "MAUBIEU";
//            cmd1.CommandType = CommandType.StoredProcedure;
//            cmd1.Parameters.Add(new SqlParameter("@MaCN", comboBoxMaCN.Text));
//            cmd1.Parameters.Add(new SqlParameter("@Date1", dateTimePicker1.Value.Date));
//            cmd1.Parameters.Add(new SqlParameter("@Date2", dateTimePicker2.Value.Date));
//            cmd1.ExecuteNonQuery();
//            adap1.SelectCommand = cmd1;
//            table2.Clear();
//            adap1.Fill(table2);
//            dataGridView1.DataSource = table2;
//            int i;
//i = dataGridView1.CurrentRow.Index;
//            textBoxTenCN.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();

//    //
//    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//{
//    //textBoxMaCN.ReadOnly = true;
//    int i;
//    i = dataGridView1.CurrentRow.Index;
//    comboBoxMaCN.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();



//}