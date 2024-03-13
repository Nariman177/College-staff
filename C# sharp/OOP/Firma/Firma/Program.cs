using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AO ao = new AO();
            TOO to = new TOO();
            IP ip = new IP();
            ao.Name = "Wel";
            Console.WriteLine("Name AO is: " + ao.Name + "\r\n");
            Console.Write("Оплата");
            ao.payment();

        }
    }

    interface stroi
    {
        void cement();
        void kirpish();

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

    public abstract class Firma
    {

    }
    public class AO : Firma, gruz
    {
        public string Name;
        public void payment()
        {
            Console.WriteLine("800тг");
        }
       public void massa()
       {
           
       }
    }
    public class TOO : Firma
    {
        
    }
    public class IP : Firma, carar
    {
        public void marka()
        { 
             Console.WriteLine("Марка автомобиля: Мерседес");
        }
    }
}
