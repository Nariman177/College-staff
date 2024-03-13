using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "hello world";
            text = text.Trim();
            text = text.Trim(new char[] {'d', 'h'});
            Console.WriteLine(text);
        }
    }
}
