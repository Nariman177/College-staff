using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztj_1
{
    internal class Program
    {

        public static string name;
        public static int postuplenye;
        public static int rodilsa;
        public static string pol;
        public static string national;

        static void Main(string[] args)
        {
            Console.Write("введите имя: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Введите пол: ");
            pol = Convert.ToString(Console.ReadLine());
            Console.Write("Национальность: ");
            national = Convert.ToString(Console.ReadLine());

            Console.Write("Год Рождение: ");
            rodilsa = int.Parse(Console.ReadLine());
            if (rodilsa >= 1990 && rodilsa >= 1995)
            {
                Console.Write("Верный год рождение");
            }
            Console.Write("Год Поступление: ");
            postuplenye = int.Parse(Console.ReadLine());
            if (postuplenye >= 1996 && postuplenye >= 2011)
            {
                Console.Write("Верный год");
            }

            Console.WriteLine("ФИО: {0}\t Год рождения:{1}\t год поступления {2}\t пол {3}\t национальность {4}\\t ", Program.name, Program.postuplenye, Program.rodilsa, Program.pol, Program.national);


        }



    }

}
