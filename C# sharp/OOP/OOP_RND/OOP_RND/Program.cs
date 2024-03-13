using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint oddCountsNumber = 0;
            uint evenCountsNumber = 0;

            Console.Write("введите первое число в диапазоне");
            int currentValue   = int.Parse(Console.ReadLine());
            Console.Write("введите последнее число в диапазоне");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2==0)
                {
                    evenCountsNumber ++;
                }
                else
                {
                    oddCountsNumber ++;
                }
            }
            Console.WriteLine("количество нечетных чисел " + oddCountsNumber);
            Console.WriteLine("количество четных чисел " + evenCountsNumber);


        }
    }
}
