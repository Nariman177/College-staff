using System;
using System.IO;

namespace Directoiry
{
    internal class Form
    {
        static void DirInfo(DirectoryInfo di)
        {
            Console.WriteLine("====== Directory Info ======");
            Console.WriteLine("Fullname" + di.FullName);
            Console.WriteLine("Name : " + di.Name);
            Console.WriteLine("Parent: " + di.Parent);
            Console.WriteLine("Craetion :" + di.CreationTime);
            Console.WriteLine("Root: " + di.Root);
            Console.WriteLine("===========");

        }
        static void Main(string[] args)
        {
            DirectoryInfo di1 = new DirectoryInfo(@"C:\MyDir");
            DirectoryInfo di2 = new DirectoryInfo(@"с-\MyDir\temp");

            try
            {
                di1.Create();
                di2.Create();

                DirInfo(di1);
                DirInfo(di2);

                Console.WriteLine("Жою әрекеті {0}",di1.Name);
                di1.Delete();
            }
            catch (Exception)
            {
                Console.WriteLine("Әрекет іске аспады");
            }
        }
        
    }
}
