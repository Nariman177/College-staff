using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp";

            string [] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].EndsWith(".exe"))
                {
                    File.Delete(files[i]);
                }

            }
        }
    }
}
