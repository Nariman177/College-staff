using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Призма
{
    internal class Prisma
    {
        


      
        static void Main(string[] args)
        {
            Console.Write("Введите cторону призмы: ");
            double a = double.Parse(Console.ReadLine());
            double osnova = Math.Pow(a, 2) * Math.Sqrt(3) / 2;
            double pRomb = a * 4;
            double height = pRomb / 2;
            double V = osnova * height;
            double sPrism = (pRomb * height) + (2 * osnova);
            Console.WriteLine("сторона призмы = " + a + "см");
            Console.WriteLine("периметр ромба = " + pRomb + "см");
            Console.WriteLine("площадь ромба(основы призмы) = " + osnova + "см/кв");
            Console.WriteLine("высота призмы = " + height + "см");
            Console.WriteLine("обьем призмы= " + V + "см/куб");
            Console.WriteLine("Площадь поверхности призмы = " + sPrism + "см/кв");



        }


    }

}

