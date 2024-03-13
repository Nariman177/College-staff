using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace second
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "456-435-2318";
            Regex regex = new Regex("[0-9]{3}-[0-9]{3}-[0-9]{4}");
            //Regex regex = new Regex(@"\d{3}-\d{3}-\d{4}");

            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    MessageBox.Show(match.Value);

            }
            else
            {
                MessageBox.Show("Сәйкестік жоқ");
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
