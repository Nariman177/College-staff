using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strtr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("Hello world");
            textBox1.Text = (sb + "\r\n" + "длинна строки: " + sb.Length + "\r\n" + "Емкость строки: " + sb.Capacity);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("Hello world");
            sb.Append("!");
            sb.Insert(6, "virtual ");
            textBox2.Text = Convert.ToString(sb);

            
            /*sb.R eplace("world", "school");
            textBox2.Text = Convert.ToString(sb);*/
             
            /*sb.Remove(6,10);
            textBox2.Text = Convert.ToString(sb);*/

            string s = sb.ToString();
            textBox2.Text = s;
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("Hазвание: ");
            textBox3.Text = Convert.ToString("Длинна строки: " + sb.Length + "\r\n" + "Емкость строки: " + sb.Capacity);

            sb.Append("Оптимус");
            textBox3.Text = Convert.ToString("Длинна строки: " + sb.Length + "\r\n" + "Емкость строки: " + sb.Capacity);

            sb.Append(" Прайм");
            textBox3.Text = Convert.ToString(sb + "\r\n" + "Длинна строки: " + sb.Length + "\r\n" + "Емкость строки: " + sb.Capacity);
        }
    }
}
