using System;
using System.IO;

namespace Directory4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader f = new StreamReader("text.txt");
                string s;
                long i = 0;
                while ((s = f.ReadLine()) != null)
                Console.WriteLine("{0}: {1}",++i,s);
                f.Close();

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Проверьте правильность имени файла! ");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return;
            }
        }
    }
}
