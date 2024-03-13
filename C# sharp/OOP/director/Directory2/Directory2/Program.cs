using System;
using System.IO;

namespace Directory2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Destname = @"c:\temp";
                DirectoryInfo dest = new DirectoryInfo(Destname);
                dest.Create();

                DirectoryInfo dir = new DirectoryInfo(@"\C:\Изображения");
                if (!dir.Exists)
                {
                    Console.WriteLine(dir.Name + "каталогы жок");
                    return;

                }
                FileInfo[] files = dir.GetFiles("*.jpg");
                foreach (FileInfo f in files)
                f.CopyTo(dest + f.Name);
                Console.WriteLine("jpg - файлдары " + files.Length + "скопировано");

            }  
            catch (Exception e)
            {
                Console.WriteLine("Eror: " + e.Message);
            }
        }
    }
}
