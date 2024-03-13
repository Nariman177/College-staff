using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace амп
{
    internal class Program : Recktangle
    {
        static void Main(string[] args)
        {
            //Cvadrat cvadrat = new Cvadrat();

            

            Recktangle recktangle = new Recktangle();
            recktangle.height = 5;
            recktangle.width = 10;
            double S = recktangle.height * recktangle.width;
            Console.WriteLine("Высота прямоугольника: " + recktangle.height);
            Console.WriteLine("Ширина прямоугольника: " + recktangle.width);
            Console.WriteLine("Площадь прямоугольника: " + S);

            Crug crug = new Crug();
            int radius = 20;
            double s = Math.Pow(radius,2) * Math.PI;
            Console.Write("Радиус круга: " + radius + "\t" + "Площадь круга: " + s);





        }




    }
}
