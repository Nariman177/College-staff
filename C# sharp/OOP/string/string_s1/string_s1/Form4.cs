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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "и поэтому все так произошло";
            /*string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            textBox1.Text = Convert.ToString(words);*/
            string[] words = text.Split(new char[] { ' ' });

            foreach (string word in words)
            {
                textBox1.Text = Convert.ToString(word);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}
