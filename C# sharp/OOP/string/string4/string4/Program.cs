
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "apple";
            string s2 = "a day";
            string s3 = "keeps";
            string s4 = "a doctor";
            string s5 = "away";

            string[] values = new string[] { s1, s2, s3, s4, s5 };
            String s10 = String.Join(" ", values);
            Console.WriteLine(s10);

        }
    }
}
