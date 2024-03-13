using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strıtrı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   

        private void Form1_Load(object sender, EventArgs e)
        {
            
           

        }
        
        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y = 0.5;
            double m = 1;
            double w = 3;
            double d = Math.PI * Math.Pow(y,2);
            double x = d * m;
            double z = w * x;
            textBox5.Text = Convert.ToString(z);

       
        }
    }
}
