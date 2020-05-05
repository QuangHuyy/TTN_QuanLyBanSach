using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanSach
{
    public partial class FormBanChay : Form
    {
        public FormBanChay()
        {
            InitializeComponent();
        }

        private void Textbanchay_TextChanged(object sender, EventArgs e)
        {

            string innam = textbanchay.Text;

            DataTable dt = new DataTable();
            string patternFi = @"\d";
            Regex myRegex = new Regex(patternFi);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            if (textbanchay.Text == "")
            {
                MessageBox.Show("MOI BAN NHAP NAM !!");
            }
            if (myRegex.IsMatch(innam) == false)
            {
                MessageBox.Show("BAN CHI DC NHAP SO");
                textbanchay.Text = "";
            }
            if (myRegex.IsMatch(innam) == true)
            {
                
                string query = "select sach.TenS, Theloai.TenTL, Tacgia.TenTG,Nhaxuatban.MaNXB, sanpham.NamXB, (NH.ban *100 / NH.nhap ) ChatLuong from nhaxuatban, theloai, tacgia,SANPHAM,SACH , (select sum(GDBAN.SoLuong) ban,sum(GDNHAP.SoLuong) nhap ,SANPHAM.MaSP from sanpham, HDBAN, GDBAN,GDNHAP where hdban.MaHDB=gdban.MaHDB and GDNHAP.MaSP=SANPHAM.MaSP and gdban.MaSP=sanpham.MaSP and year(HDBAN.NgayBan)= '" + innam + "' group by SANPHAM.MaSP) NH "
                  + " where  NH.MaSP=SANPHAM.MaSP and SANPHAM.MaS=SACH.MaS and sach.MaTG=TACGIA.MaTG and sach.MaTL=THELOAI.MaTL and NHAXUATBAN.MaNXB=SACH.MaNXB and (NH.ban *100 / NH.nhap ) > 20";
                dt = Program.da.readDatathroughAdapter(query);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
