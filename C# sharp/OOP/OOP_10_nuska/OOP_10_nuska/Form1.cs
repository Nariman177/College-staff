using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_10_nuska
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Random rnd = new Random();
            int a;
            
            textBox2.Text = Convert.ToString(a);
            int result = 0;

            
            //rnd.Next(0, 999);



            /*for (int i = 0; i < 999; i++)
            {
                
                if (a[i] % 2 == 0)
                {
                    richTextBox2.Text += Convert.ToString(a[i]);

                }


               
            }*/
        }
    }
}
