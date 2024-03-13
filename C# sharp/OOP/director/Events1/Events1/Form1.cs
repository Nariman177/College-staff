using System;
using System.Windows.Forms;

namespace Events1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Calculate
        {
            public event delegateOddNumber eventOddNumber;
            public delegate void delegateOddNumber();

            private void button1_Click(object sender, EventArgs e)
            {
                int ans;
                ans = 4 + 3;
                //textbox = Convert.ToString(ans);

                if ((ans % 2 != 0) && (eventOddNumber != null))
                {
                    eventOddNumber();
                }
                else
                {
                    MessageBox.Show("Это четное число событие не сработало");
                }
            }

            


        }

       
    }
}
