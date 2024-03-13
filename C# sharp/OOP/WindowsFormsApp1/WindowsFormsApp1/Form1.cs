using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, g;
            double h, h1, h2, h3, h4;
            a = Convert.ToInt32(textBox1.Text);
            if ((a >= 1000) && (a <= 9999))
            {
                b = a / 1000;
                textBox2.Text = Convert.ToString(b); //1-сан
                c = a / 100;
                c = c % 10;
                textBox3.Text = Convert.ToString(c); //2-сан
                d = a / 10;
                d = d % 10;
                textBox4.Text = Convert.ToString(d); //3-сан
                f = a % 10;
                textBox5.Text = Convert.ToString(f); //4-сан
                g = (c * c) + (d * d) + (f * f);
                textBox6.Text = Convert.ToString(g);
                h = (Math.Sqrt(b));
                textBox7.Text = Convert.ToString(h);
                h1 = Math.Round(h);
                textBox8.Text = Convert.ToString(h1);
                h2 = Math.Floor(h);
                textBox9.Text = Convert.ToString(h2);
                h3 = Math.Truncate(h);
                textBox10.Text = Convert.ToString(h3);
                h4 = Math.Ceiling(h);
                textBox11.Text = Convert.ToString(h4);

            }
            else
            {
                string message = "4 - таңбалы сан енгіз";
                string caption = "Қате";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double t, l, m, k, x, y, r, j, q;
            t = Convert.ToDouble(textBox11.Text);
            k = Convert.ToDouble(textBox10.Text);
            m = Convert.ToDouble(textBox9.Text);
            l = Convert.ToDouble(textBox8.Text);
            x = Convert.ToDouble(textBox12.Text);
            if (x > 0)
            {
                y = Convert.ToDouble(textBox13.Text);
                j = (m * m * m * m) - (l * l * l * l * l);
                if (j != 0)
                {
                    r = Math.Round(((t * t) - (k * k)) / (j) + (Math.Sqrt((Math.Sqrt(Math.Abs(x)) + y) / (12 - Math.Abs(x))) + 4));
                    textBox14.Text = Convert.ToString(r);
                }
                else
                {
                    string message = "Санды 0 бөліге болмайды";
                    string caption = "Қате";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                }

            }
            else
            {
                string message = "Минус танбалы санды түбірден шығаруға болмайды";
                string caption = "Қате"; 
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }

        }
    }
}
