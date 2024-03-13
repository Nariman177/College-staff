using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car car = new car();
            track to = new track();
            car.Name = "Toyota Camry";
            car.tg = 800;
            Console.WriteLine("Имя легковой машины " + car.Name);
            Console.WriteLine("Стоимость " + car.tg + "тг");

            to.t_Name = "Volva";
            Console.WriteLine("Имя грузовой машины " + to.t_Name);
            Console.Write("Оплата: ");
            to.payment();
           
        }

        interface gruz
        {
           
            void payment();
            void massa();
        }
        interface carar
        {
            void marka();
        }

        public abstract class Machine
        {

        }
        public class car : Machine, carar
        {
            public string Name;
            public int tg;
            public void marka()
            {

            }
        }
        public class track : Machine, gruz
        {
            public string t_Name;

            public void massa()
            {

            }

            public void payment()
            {
                Console.WriteLine("8000тг");
            }
        }


    }


}
