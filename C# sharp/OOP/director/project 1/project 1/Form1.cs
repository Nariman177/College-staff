using System.IO;
using System.Windows.Forms;

namespace project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            
            /*try
            {
                string Destname = @"c:\Dekstop";
                DirectoryInfo dest = new DirectoryInfo(Destname);
                dest.Create();
                DirectoryInfo dir = new DirectoryInfo(@"winter.jpg");

                if (!dir.Exists)
                {
                    textBox1.Text = ("каталог не найден" + dir.Name);
                    return;
                }
                FileInfo[] files = dir.GetFiles("*.jpg");
                foreach (FileInfo f in files)
                f.CopyTo(dest + f.Name);
                textBox1.Text = ("jpg-файлы" + files.Length + "скопировано");
            }
            catch (Exception e){ 
            }*/
        }
    }
}
