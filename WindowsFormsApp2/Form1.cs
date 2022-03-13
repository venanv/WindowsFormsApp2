using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        int size1 = 25;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Substring(0,4).ToUpper() == "ISI:")
            {
                label2.Text = textBox1.Text.Substring (4);
            }
            else if (textBox1.Text.ToUpper() == "SHOWN:")
            {
                label2.Visible = true;
            }
            else if (textBox1.Text.ToUpper() == "HIDE:")
            {
                label2.Visible = false;
            }
            else if (textBox1.Text.ToUpper() == "BESARKAN:")
            {
                size1 = size1 + 3;
                label2.Font = new Font(Name, size1);
            }
            else if (textBox1.Text.ToUpper() == "KECILKAN:")
            {
                size1 = size1 - 3;
                label2.Font = new Font(Name, size1);
            }
            else if (textBox1.Text.Substring(0,6).ToUpper() == "WARNA:")
            {
                if (textBox1.Text.Substring(6).ToUpper() == "MERAH")
                {
                    label2.ForeColor = Color.Red;
                }
                else if (textBox1.Text.Substring(6).ToUpper() == "BIRU")
                {
                    label2.ForeColor = Color.Blue;
                }
                else if (textBox1.Text.Substring(6).ToUpper() == "HIJAU")
                {
                    label2.ForeColor = Color.Green;
                }
            }
        }
    }
}
