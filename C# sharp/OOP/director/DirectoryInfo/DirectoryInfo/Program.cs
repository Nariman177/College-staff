using System;
using System.IO;

namespace DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter f = new StreamWriter("text.txt");
                f.WriteLine("вывести текст : ");
                double a = 12.234;
                int b = 29;
                f.WriteLine("a = {0.6:C} b = {1.2:X}", a, b);
                f.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
                return;
            }
        }
    }
}
