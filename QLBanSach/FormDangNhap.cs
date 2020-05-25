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
        string ToMoney(string m)
        {
            string t = new string(m.ToCharArray()
                    .Where(c => !Char.IsWhiteSpace(c))
                    .ToArray()); 
            int i = t.Length;

            while (i > 3)
            {
                t = t.Insert(i - 3, " ");
                i -= 3;
                skipTextChanged = true;
            }

            return t;
        }

        bool skipTextChanged = false;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (skipTextChanged)
            {
                skipTextChanged = false;
                return;
            }
            textBox3.Text = ToMoney(textBox3.Text);
            textBox3.SelectionStart = textBox3.Text.Length;
            textBox3.SelectionLength = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (skipTextChanged)
            {
                skipTextChanged = false;
                return;
            }
            textBox2.Text = ToMoney(textBox2.Text);
        }
    }
}
