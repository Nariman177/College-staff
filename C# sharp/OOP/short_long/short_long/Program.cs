using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_long
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое слово ");
            string str = Console.ReadLine();
        

            str = str + " ";
            int len = str.Length;
            String k = " ", max = " ", min = " ";
            char ch;

            int p, max1 = 0;
            int min1 = len;
            for (int i = 0; i < len; i++)
            {
                ch = str[i];
                if (ch != ' ')
                {
                    k = k + ch;
                }
                else
                {
                    p = k.Length - 1;
                    if (p < min1)
                    {
                        min1 = p;
                        min = k;
                    }
                    if (p > max1)
                    {
                        max1 = p;
                        max = k;
                    }
                    k = " ";
                }
            }
            Console.Write("самое короткое слово = " + min + " длинна слово = " + min1 + "\n");
            Console.Write("самое длинное слово = " + max + " длинна слово = = " + max1);

        }
    }
}
