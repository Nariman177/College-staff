using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            for (int i = 0; i < a.Length; i++) { Console.WriteLine(a[i]); }
            Console.WriteLine($"{a[0]} : {a[1]}");
            Console.WriteLine($"{a[2]} : {a[3]}");
            Console.WriteLine($"{a[1]} : {a[2]}");
            Console.WriteLine($"{a[0]} : {a[3]}");
            Console.WriteLine($"{a[0]} : {a[2]}");
            Console.WriteLine($"{a[1]} : {a[3]}");

            double num = double.Parse(a);
            double i4 = num % 10;
            double i1 = num / 1000;
            double sum = i1 + i4;

            Console.WriteLine(Math.Round((decimal) sum));

            double i2 = ((num / 100) % 10);
            double i3 = ((num / 10)%10);
            Console.WriteLine(Math.Round(i1 + i2));
            Console.WriteLine(Math.Round(i3 * i4));
        }
    }
}
