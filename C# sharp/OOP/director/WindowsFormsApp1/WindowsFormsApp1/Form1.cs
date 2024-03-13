using System;
using System.IO;
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
            try
            {
                string Destname = @"C:\Narimg";
                DirectoryInfo dest = new DirectoryInfo(Destname);
                dest.Create();

                DirectoryInfo dir = new DirectoryInfo(@"C:\NurBot");
                if (!dir.Exists)
                {
                    textBox3.Text = Convert.ToString(dir.Name + "каталогы жок");
                    return;

                }
                FileInfo[] files = dir.GetFiles("*.jpg");
                foreach (FileInfo f in files)
                    f.CopyTo(dest + f.Name);
                textBox6.Text = Convert.ToString("jpg - файлдары " + files.Length + "скопировано");

            }
            catch (Exception xe)
            {
                textBox3.Text = Convert.ToString("Eror: " + xe.Message);
            }

        }

        
    }
}
