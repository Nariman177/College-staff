using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTJ12__13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Колокол";
            cat.weight = 12;
            cat.feeding_time = 1200;
            Console.WriteLine("Кошку зовут:" + " " + cat.Name);
            Console.WriteLine("вес кошки: " + cat.weight);
            Console.WriteLine("время кормления кошки: " + cat.feeding_time);
        }
    }
    class Pet
    {
        public string Name { get; set; }
        public int weight { get; set; }
        public double feeding_time { get; set; }

    }

    class Cat : Pet{ 

        public void Catsouund()
        {
            Console.Write("мурлычят");
        }
    
    }
}