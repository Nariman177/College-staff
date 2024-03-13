using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace second
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
             //Regex regex = new Regex(@"\w*губ\w*");
            Regex regex = new Regex(@"туп(\w*)");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                   // textBox1.Text = match.Value;
                MessageBox.Show(match.Value);
            }
            else
            {
                //textBox1.Text = Convert.ToString("Совпадений не найдено");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
