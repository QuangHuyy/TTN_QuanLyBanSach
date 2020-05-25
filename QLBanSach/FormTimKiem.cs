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
    public partial class FormTimKiem : Form
    {
        public FormTimKiem()
        {
            InitializeComponent();
        }

        private void Btntimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            string patternFi = @"\d";
            Regex myRegex = new Regex(patternFi);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            DataTable dt7 = new DataTable();
            DataTable dt8 = new DataTable();
            DataTable dt9 = new DataTable();
            DataTable dt10 = new DataTable();
            DataTable dt11 = new DataTable();
            DataTable dt12 = new DataTable();
            DataTable dt13 = new DataTable();
            DataTable dt14 = new DataTable();
            DataTable dt15 = new DataTable();
            DataTable dt16 = new DataTable();
            DataTable dt17 = new DataTable();
            DataTable dt18 = new DataTable();
            if (listbox.GetItemChecked(0) == true && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null)
            {
                if (texttim2.Text == "" && texttim3.Text == "")
                {
                    string query1 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                  + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                  + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                  + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and sach.tensach =N'" + texttim1.Text + "'";
                    dt = Program.da.readDatathroughAdapter(query1);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(1) == true && listbox.GetItemChecked(0) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null)
            {
                if (texttim2.Text == "" && texttim3.Text == "")
                {
                    string query2 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                 + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                 + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                 + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and theloai.tentl =N'" + texttim1.Text + "'";
                    dt1 = Program.da.readDatathroughAdapter(query2);
                    dataGridView1.DataSource = dt1;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(2) == true && listbox.GetItemChecked(0) == false && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null)
            {
                if (texttim2.Text == "" && texttim3.Text == "")
                {
                    string query3 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                  + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                  + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                  + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and tacgia.tentg =N'" + texttim1.Text + "'";
                    dt2 = Program.da.readDatathroughAdapter(query3);
                    dataGridView1.DataSource = dt2;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(3) == true && listbox.GetItemChecked(0) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null)
            {
                if (texttim2.Text == "" && texttim3.Text == "")
                {
                    string query4 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                 + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                 + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                 + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and ngonngu.tennn =N'" + texttim1.Text + "'";
                    dt3 = Program.da.readDatathroughAdapter(query4);
                    dataGridView1.DataSource = dt3;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(4) == true && listbox.GetItemChecked(0) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null)
            {
                if (texttim2.Text == "" && texttim3.Text == "")
                {
                    string query5 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                 + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                 + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                 + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and series.tenseries =N'" + texttim1.Text + "'";
                    dt4 = Program.da.readDatathroughAdapter(query5);
                    dataGridView1.DataSource = dt4;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(5) == true && listbox.GetItemChecked(0) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null)
            {
                if (texttim2.Text == "" && texttim3.Text == "")
                {
                    string query6 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                 + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                 + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                 + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and dichgia.tendg =N'" + texttim1.Text + "'";
                    dt5 = Program.da.readDatathroughAdapter(query6);
                    dataGridView1.DataSource = dt5;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(6) == true && listbox.GetItemChecked(0) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null)
            {
                if (texttim2.Text == "" && texttim3.Text == "")
                {
                    string query7 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                 + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                 + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                 + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and nhaxuatban.tennxb =N'" + texttim1.Text + "'";
                    dt6 = Program.da.readDatathroughAdapter(query7);
                    dataGridView1.DataSource = dt6;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(7) == true && listbox.GetItemChecked(0) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(1) == false && texttim1.Text != null)
            {
                if (texttim2.Text == "" && texttim3.Text == "")
                {
                    if (myRegex.IsMatch(texttim1.Text) == true)
                    {

                        string query8 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                  + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                  + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                  + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and sach.namxb ='" + int.Parse(texttim1.Text) + "'";
                        dt7 = Program.da.readDatathroughAdapter(query8);
                        dataGridView1.DataSource = dt7;
                    }
                    else if (myRegex.IsMatch(texttim1.Text) == false)
                    {
                        MessageBox.Show("BAN CHI DC NHAP SO");
                        texttim1.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            // 
            if (listbox.GetItemChecked(1) == true && listbox.GetItemChecked(0) == true && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != "" && texttim2.Text != "")
            {

                if (texttim3.Text == "")
                {
                    string query9 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                 + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                 + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                 + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and sach.tensach =N'" + texttim1.Text + "' " + " and theloai.tentl =N'" + texttim2.Text + "'";
                    dt8 = Program.da.readDatathroughAdapter(query9);
                    dataGridView1.DataSource = dt8;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(2) == true && listbox.GetItemChecked(0) == true && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null && texttim2.Text != null)
            {

                if (texttim3.Text == "")
                {
                    string query10 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and sach.tensach =N'" + texttim1.Text + "' " + " and tacgia.tentg =N'" + texttim2.Text + "'";
                    dt9 = Program.da.readDatathroughAdapter(query10);
                    dataGridView1.DataSource = dt9;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(3) == true && listbox.GetItemChecked(0) == true && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null && texttim2.Text != null)
            {

                if (texttim3.Text == "")
                {
                    string query11 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                 + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                 + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                 + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and sach.tensach =N'" + texttim1.Text + "' " + " and ngonngu.tennn =N'" + texttim2.Text + "'";
                    dt10 = Program.da.readDatathroughAdapter(query11);
                    dataGridView1.DataSource = dt10;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(4) == true && listbox.GetItemChecked(0) == true && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null && texttim2.Text != null)
            {

                if (texttim3.Text == "")
                {
                    string query12 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and sach.tensach =N'" + texttim1.Text + "' " + " and series.tenseries =N'" + texttim2.Text + "'";
                    dt11 = Program.da.readDatathroughAdapter(query12);
                    dataGridView1.DataSource = dt11;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(5) == true && listbox.GetItemChecked(0) == true && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null && texttim2.Text != null)
            {

                if (texttim3.Text == "")
                {
                    string query14 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                 + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                 + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                 + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and sach.tensach =N'" + texttim1.Text + "' " + " and dichgia.tendg =N'" + texttim2.Text + "'";
                    dt12 = Program.da.readDatathroughAdapter(query14);
                    dataGridView1.DataSource = dt12;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(6) == true && listbox.GetItemChecked(0) == true && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null && texttim2.Text != null)
            {

                if (texttim3.Text == "")
                {
                    string query15 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                   + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                   + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                   + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and sach.tensach =N'" + texttim1.Text + "' " + " and nhaxuatban.tennxb =N'" + texttim2.Text + "'";
                    dt14 = Program.da.readDatathroughAdapter(query15);
                    dataGridView1.DataSource = dt14;
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (listbox.GetItemChecked(7) == true && listbox.GetItemChecked(0) == true && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(1) == false && texttim1.Text != null && texttim2.Text != null)
            {

                if (texttim3.Text == "")
                {
                    if (myRegex.IsMatch(texttim2.Text) == true)
                    {

                        string query16 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                            + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                            + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                            + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and sach.tensach =N'" + texttim1.Text + "' " + " and sach.namxb ='" + int.Parse(texttim2.Text) + "'";
                        dt15 = Program.da.readDatathroughAdapter(query16);
                        dataGridView1.DataSource = dt15;
                    }
                    if (myRegex.IsMatch(texttim2.Text) == false)
                    {
                        MessageBox.Show("BAN CHI DC NHAP SO");
                        texttim2.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("BAN NHAP CHUA DUNG O TEXT");
                }
            }
            if (((listbox.GetItemChecked(0) == false && listbox.GetItemChecked(1) == true && listbox.GetItemChecked(2) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(1) == true && listbox.GetItemChecked(3) == true && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(1) == true && listbox.GetItemChecked(4) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(1) == true && listbox.GetItemChecked(5) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(1) == true && listbox.GetItemChecked(6) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(7) == true && listbox.GetItemChecked(1) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(2) == false)) && texttim1.Text != "" && texttim2.Text != "")
            {
                MessageBox.Show("BAN CHI DUOC CHON TIM THEO TEN SACH VA 1 LUA CHON KHAC !");
            }
            if (((listbox.GetItemChecked(0) == false && listbox.GetItemChecked(2) == true && listbox.GetItemChecked(3) == true && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(2) == true && listbox.GetItemChecked(4) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(2) == true && listbox.GetItemChecked(5) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(6) == true && listbox.GetItemChecked(2) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(7) == true && listbox.GetItemChecked(2) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false)) && texttim1.Text != "" && texttim2.Text != "")
            {
                MessageBox.Show("BAN CHI DUOC CHON TIM THEO TEN SACH VA 1 LUA CHON KHAC !");
            }
            if (((listbox.GetItemChecked(0) == false && listbox.GetItemChecked(4) == true && listbox.GetItemChecked(3) == true && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(3) == true && listbox.GetItemChecked(5) == true && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(3) == true && listbox.GetItemChecked(6) == true && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(3) == true && listbox.GetItemChecked(7) == true && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false)) && texttim1.Text != "" && texttim2.Text != "")
            {
                MessageBox.Show("BAN CHI DUOC CHON TIM THEO TEN SACH VA 1 LUA CHON KHAC !");
            }
            if (((listbox.GetItemChecked(0) == false && listbox.GetItemChecked(4) == true && listbox.GetItemChecked(5) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(4) == true && listbox.GetItemChecked(6) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(4) == true && listbox.GetItemChecked(7) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false)) && texttim1.Text != "" && texttim2.Text != "")
            {
                MessageBox.Show("BAN CHI DUOC CHON TIM THEO TEN SACH VA 1 LUA CHON KHAC !");
            }
            if (((listbox.GetItemChecked(0) == false && listbox.GetItemChecked(5) == true && listbox.GetItemChecked(6) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(7) == false) || (listbox.GetItemChecked(0) == false && listbox.GetItemChecked(5) == true && listbox.GetItemChecked(7) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(6) == false)) && texttim1.Text != "" && texttim2.Text != "")
            {
                MessageBox.Show("BAN CHI DUOC CHON TIM THEO TEN SACH VA 1 LUA CHON KHAC !");
            }
            if (((listbox.GetItemChecked(0) == false && listbox.GetItemChecked(6) == true && listbox.GetItemChecked(7) == true)) && texttim1.Text != "" && texttim2.Text != "")
            {
                MessageBox.Show("BAN CHI DUOC CHON TIM THEO TEN SACH VA 1 LUA CHON KHAC !");
            }
            if (listbox.GetItemChecked(0) == true && listbox.GetItemChecked(1) == true && listbox.GetItemChecked(2) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null && texttim2.Text != null && texttim1.Text != null && texttim3.Text != null)
            {
                string query17 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and sach.tensach =N'" + texttim1.Text + "' " + " and theloai.tentl =N'" + texttim2.Text + "' " + " and tacgia.tentg ='" + texttim3.Text + "'";
                dt16 = Program.da.readDatathroughAdapter(query17);
                dataGridView1.DataSource = dt16;

            }
            if (listbox.GetItemChecked(0) == true && listbox.GetItemChecked(1) == true && listbox.GetItemChecked(2) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && (texttim1.Text == null || texttim2.Text == null || texttim3.Text == null))
            {
                MessageBox.Show("BAN NHAP THIEU O TEXT");
            }
            if (listbox.GetItemChecked(0) == true && listbox.GetItemChecked(3) == true && listbox.GetItemChecked(4) == true && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null && texttim2.Text != null && texttim1.Text != null && texttim3.Text != null)
            {
                string query18 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                                + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                                + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                                + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and sach.tensach =N'" + texttim1.Text + "' " + " and ngonngu.tenn =N'" + texttim2.Text + "' " + " and series.tenseries ='" + texttim3.Text + "'";
                dt17 = Program.da.readDatathroughAdapter(query18);
                dataGridView1.DataSource = dt17;

            }
            if (listbox.GetItemChecked(0) == true && listbox.GetItemChecked(3) == true && listbox.GetItemChecked(4) == true && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(5) == false && listbox.GetItemChecked(6) == false && listbox.GetItemChecked(7) == false && (texttim1.Text == null || texttim2.Text == null || texttim3.Text == null))
            {
                MessageBox.Show("BAN NHAP THIEU O TEXT");
            }
            if (listbox.GetItemChecked(0) == true && listbox.GetItemChecked(5) == true && listbox.GetItemChecked(6) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(7) == false && texttim1.Text != null && texttim2.Text != null && texttim1.Text != null && texttim3.Text != null)
            {
                string query19 = "select sach.TenSach, Theloai.TenTL, Tacgia.TenTG,DichGia.TenDG,NgonNgu.TenNN,Nhaxuatban.TenNXB, sach.giaban, series.tenseries "
                               + " from sach,series, theloai, tacgia, dichgia, ngonngu,nhaxuatban, theloai_sach, tacgia_sach, dichgia_sach, ngonngu_sach where "
                               + " sach.masach=theloai_sach.masach and theloai_sach.matl=theloai.matl and sach.masach=ngonngu_sach.masach and ngonngu_sach.mann=ngonngu.mann and sach.masach=dichgia_sach.masach and dichgia.madg=dichgia_sach.madg and sach.masach=tacgia_sach.masach and tacgia_sach.matg=tacgia.matg "
                               + " and sach.manxb=nhaxuatban.manxb and sach.maseries=series.maseries and sach.tensach =N'" + texttim1.Text + "' " + " and dichgia.tendg =N'" + texttim2.Text + "' " + " and nhaxuatban.tennxb ='" + texttim3.Text + "'";
                dt18 = Program.da.readDatathroughAdapter(query19);
                dataGridView1.DataSource = dt18;

            }
            if (listbox.GetItemChecked(0) == true && listbox.GetItemChecked(5) == true && listbox.GetItemChecked(6) == true && listbox.GetItemChecked(3) == false && listbox.GetItemChecked(4) == false && listbox.GetItemChecked(1) == false && listbox.GetItemChecked(2) == false && listbox.GetItemChecked(7) == false && (texttim1.Text == null || texttim2.Text == null || texttim3.Text == null))
            {
                MessageBox.Show("BAN NHAP THIEU O TEXT");
            }



        }

        void test()
        {
            //string query = "SLECT * FROM SACH WHERE ";
            //string masach = " Ma Sach is not null ";
            //string tacGia = "";

            //string truyvantrongsql = query + masach + tacGia;

            //tacGia = txtboxTacgia.Text;
            //masach = txtboxmasach.Text;
        }
    }
}
