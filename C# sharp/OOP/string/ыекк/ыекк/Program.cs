using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ыекк
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "хороший день";
            text = text.Replace("хороший", "плохой");
            Console.WriteLine(text);

            text = text.Replace("о", "");
            Console.WriteLine(text);
        }
    }
}
