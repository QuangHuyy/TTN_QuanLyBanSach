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
    public partial class FormDangNhap : Form
    {
        static Form parent;
        public FormDangNhap(Form par)
        {
            InitializeComponent();
            parent = par;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Program.LogIn();
            ((MainForm)parent).LoadComponents();
        }
    }
}
