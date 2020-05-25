using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanSach
{
    public partial class FormNhapSach : Form
    {
        public FormNhapSach()
        {
            InitializeComponent();
            loadDataDG();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void FormCapNhatSach_Load(object sender, EventArgs e)
        {

        }
        void loadDataDG()
        {
            DataTable table = new DataTable();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            string query = "select * from Sach";

            table = Program.da.readDatathroughAdapter(query);
            dataGridView1.DataSource = table;
        }
        private void FormDichGia_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
