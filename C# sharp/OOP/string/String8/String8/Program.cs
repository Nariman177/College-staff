using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello world";
            char ch = 'o';

            int indexofChar = s1.IndexOf(ch);
            Console.WriteLine(indexofChar);

            string subString = "wor";
            int indexOfSubstring = s1.IndexOf(subString);
            Console.WriteLine(indexOfSubstring);
        }
    }
}
