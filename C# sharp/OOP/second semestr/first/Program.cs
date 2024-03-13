using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            string s = "456-435-2318";
            Regex regex = new Regex(@"[0-9]{3} - [0-9]{3} - [0-9]{4}");
            Console.WriteLine(s);

            
           


        }
    }
}
