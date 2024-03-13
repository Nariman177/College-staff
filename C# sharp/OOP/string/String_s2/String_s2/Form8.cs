using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_s2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*decimal number = 0.15223m;
            //string result = string.Format("{0:f}", number);
            textBox1.Text = Convert.ToString("{0:P1}", number);*/

            long number = 87083427015;
            string result = String.Format("{0:+# (###) ###-##-#}", number);
            textBox1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
