using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string text = "Хороший день";
            text = text.Substring(2);
            Console.WriteLine(text);
            text = text.Substring(0, text.Length - 2);
            Console.Write(text);*/

            string text = "Хороший день";
            string subString = "Замечательный  ";

            text = text.Insert(8, subString);
            Console.WriteLine(text);        
        }
    }
}
