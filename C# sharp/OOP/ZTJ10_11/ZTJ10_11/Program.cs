using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTJ10_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            receipt receipt = new receipt();
            receipt.Name = "Narla Tech";
            receipt.adres = "Kunaeva 34";
            receipt.number = 87083427015;
            receipt.email = "nariman13suleimenov@gmail.com";
            Console.WriteLine("Квитанциянын аты: " + receipt.Name + "\r\n" + "Адрес: " + receipt.adres + "\r\n" + "номер телефона: " + receipt.number + "\r\n" + "email: " + receipt.email);
            conte conte = new conte();
            Console.WriteLine("накладная");
            conte.nazv = "Smartfone";
            conte.stoim = 1000;
            conte.kol = 10;
            Console.WriteLine("Название товара: " + conte.nazv + "\r\n" + "стоимость товара: " + conte.stoim + ".tg" + "\r\n" + "количество товара: " + conte.kol );



        }

        public abstract class Compa
        {
            public string Name { get; set; }
            public string adres { get; set; }
            public double number { get; set; }
            public string email { get; set; }
            public void TO()
            {
                Console.WriteLine("Информация про комапиню");
            }
        }

        public class receipt : Compa
        {
            
        }

        public class conte : Compa
        {
            public string nazv;
            public int stoim;
            public int kol;
        }

      

        public class doc : Compa
        {

        }
        public class check : Compa
        {

        }

    }

}
