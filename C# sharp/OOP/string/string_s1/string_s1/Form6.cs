using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_s1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = "hello world";
            char ch = 'o';
            int IndexOfChar = s1.IndexOf(ch);
            textBox1.Text =  Convert.ToString(IndexOfChar);

            string s2 = "wor";
            int IndexOfChar2 = s2.IndexOf(s2);
            textBox1.Text = Convert.ToString(IndexOfChar2);
        }
    }
}
