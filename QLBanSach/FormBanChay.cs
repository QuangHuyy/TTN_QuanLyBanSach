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

                
                string query = "select sach.TenSach, Theloai.TenTL, sach.tap ,DICHGIA.TenDG,Tacgia.TenTG, Ngonngu.TenNN, (NH.ban * 100 / NH.nhap) ChatLuong from NGONNGU,NGONNGU_SACH,THELOAI_SACH,TACGIA_SACH,DICHGIA_SACH, theloai, tacgia,dichgia,SACH , (select sum(GDBAN.SoLuong) ban, sum(sach.SoLuong) nhap ,sach.MaSach from sach, HDBAN, GDBAN where hdban.MaHDB = gdban.MaHDB  and gdban.MaSach = sach.MaSach and year(HDBAN.NgayBan)= '" + int.Parse(textbanchay.Text) + "' group by Sach.MaSach) NH "
                  + " where Nh.MaSach = sach.MaSach and sach.MaSach = THELOAI_SACH.MaSach and THELOAI_SACH.MaTL = THELOAI.MaTL and sach.MaSach = NGONNGU_SACH.MaSach and NGONNGU_SACH.MaNN = NGONNGU.MaNN and sach.MaSach = DICHGIA_SACH.MaSach and DICHGIA_SACH.MaDG = DICHGIA.MaDG and TACGIA.MaTG = TACGIA_SACH.MaTG and TACGIA_SACH.MaSach = sach.MaSach  and(NH.ban * 100 / NH.nhap) > 10";
                dt = Program.da.readDatathroughAdapter(query);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
