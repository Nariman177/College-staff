using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "world";

            int result = string.Compare(s1, s2);
            if (result <= 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if(result >= 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }
        }
    }
}
