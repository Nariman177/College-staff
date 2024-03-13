using System;
using System.IO;
using System.Windows.Forms;

namespace program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader f = new StreamReader("text.txt");
                string s;
                long i = 0;

                while ((s = f.ReadLine()) != null)
                    label1.Text += ("{0} : {1}",++i,s);
                    f.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("проверьте правильность имение файла");
                return;
            }
            catch (Exception xe)
            {
                MessageBox.Show("Error: " + xe.Message);
            }
        }
    }
}
