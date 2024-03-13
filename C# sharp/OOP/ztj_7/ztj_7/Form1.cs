using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ztj_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate int Calculate(int x);
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate cal = calsquare;

            textBox1.Text = Convert.ToString("Результат делегата квадрат" + cal(5) + "\n\r");
            cal = calcube;
            textBox2.Text = Convert.ToString("Результат делегата куб" + cal(5));
            
        }
        static int calsquare(int x)
        {

            return x * x;
        }

        static int calcube(int x)
        {
            return x * x * x;

        }
    }
}
