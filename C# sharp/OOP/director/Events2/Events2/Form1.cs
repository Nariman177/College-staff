using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public event delegateOddNumber eventOddNumber;
        public delegate void delegateOddNumber();

        private void button1_Click(object sender, EventArgs e)
        {
            int ans;
            ans = 4 + 4;
            textBox1.Text = Convert.ToString(ans);

            if((ans % 2 != 0) && (eventOddNumber != null))
            {
                eventOddNumber();
            }
            else
            {
                MessageBox.Show("Это четное число событие не сработало");
            }



            //MessageBox.Show = ("");
        }
       
    }
}
