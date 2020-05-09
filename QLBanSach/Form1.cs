using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
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
            //GenerateBarcode();
        }

        void GenerateBarcode()
        {
            string query = "SELECT * FROM SACH";
            DataTable dtb = Program.da.readDatathroughAdapter(query);

            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            Bitmap i;

            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            wanted_path += "\\Barcode\\";

            foreach (DataRow row in dtb.Rows)
            {
                i = writer.Write(row.ItemArray.ElementAt(0).ToString());
                i.Save(wanted_path + row.ItemArray.ElementAt(0).ToString() + ".png", ImageFormat.Png);
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
