using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTJ_5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int s, j, b;
            double jup = 0;
            double kup = 0;
            int[] a = new int[20];

            Random rnd = new Random();
            for (i = 0; i < 20; i++)
            {
                a[i] = rnd.Next(0,30);
                Console.WriteLine(a[i]);

                if (a[i] % 2 == 0)
                {
                    jup = a[i];
                    Console.WriteLine("количество четных чисел: " + jup);
                }
               
                if (a[i] != 0)
                {
                    jup = a[i];
                    Console.WriteLine("количество нечетных чисел: " + kup);
                }
                

            }

        }
    }
}
