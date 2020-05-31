using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QLBanSach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateBarcode();
            //string t = convertToUnSign3("ố là lá lã lạ xĩn chảo cạ nhà đ ư ơ ô");
            //Console.Write(t);
        }
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        void GenerateBarcode()
        {
            string query = "SELECT s.MaSach,s.MaDSach,s.TenSach,s.Namxb,x.TenNXB, g.TenTG FROM SACH s, DAUSACH d, NHAXUATBAN x, TACGIA g WHERE s.MaDSach = d.MaDSACH AND s.MaNXB = x.MaNXB AND g.MaTG = d.MaTGChinh";
            
            DataTable dtb = Program.da.readDatathroughAdapter(query);

            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            Bitmap i;

            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            wanted_path += "\\Barcode\\";

            foreach (DataRow row in dtb.Rows)
            {
                string bc = row["MaSach"].ToString() + ";" + row["TenSach"].ToString() + ";" + row["Namxb"].ToString() + ";" + row["TenNXB"].ToString() + ";" + row["TenTG"].ToString();
                bc = convertToUnSign3(bc);
                i = writer.Write(bc);
                i.Save(wanted_path + bc + ".png", ImageFormat.Png);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            pictureBox1.Image = writer.Write(textBoxEncode.Text);
            Bitmap i = writer.Write(textBoxEncode.Text);


            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            wanted_path += "\\Barcode\\1.png";
            i.Save(wanted_path, ImageFormat.Png);
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)pictureBox1.Image);
            if (result != null)
                textBoxDecode.Text = result.Text;
        }
    }
}
