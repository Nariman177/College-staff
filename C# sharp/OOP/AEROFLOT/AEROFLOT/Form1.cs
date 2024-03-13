using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEROFLOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct aeroflot
        {
            public string Name;
            public int Number;
            public string type;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name;
            int number;

            name = Convert.ToString(textBox1.Text);
            number = Convert.ToInt32(textBox2.Text);

            if (number == 10 && name == "aero")
            {

                MessageBox.Show("Такого рейса нету");

            }
            else {

                textBox4.Text = Convert.ToString("Название пункта: " + name + "\t\n" + "номер рейса: " + number );
            
            }
            
         

            
           
        }
    }
}
