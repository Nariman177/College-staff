using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "и поэтому все так произошло";
            /*string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(text);*/
            string[] words = text.Split(new char[] { ' ' });

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
