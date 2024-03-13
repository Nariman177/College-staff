using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_massivv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            myClass instance = new myClass();
            instance[2] = 21;
            for (int i = 0; i < 3; i++)
            {
                textBox1.Text += Convert.ToString(instance[i] + "\n");

            }
        }
        internal class MyClass
        {

        }
    }
    
}