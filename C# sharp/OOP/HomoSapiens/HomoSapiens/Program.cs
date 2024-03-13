using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomoSapiens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Men men = new Men();
            Woman woman = new Woman();
            Child child = new Child();
            men.Dinner();
            woman.Breakfast();
            child.Supper();
        }
        interface IHomo
        {
            void Breakfast();
            void Dinner();
            void Supper();

        }
        public abstract class Homo_sapiens
        {
        }
        public class Men : Homo_sapiens, IHomo
        {
            public void Breakfast() { }
            public void Dinner() {
                Console.WriteLine("Отец пооужинал");
            
            
            }
            public void Supper() { }
        }
        public class Woman : Homo_sapiens, IHomo {

            public void Breakfast() {
                Console.WriteLine("Мать позавтракала");
            
            }
            public void Dinner() { }
            public void Supper() { }

        }
        public class Child : Homo_sapiens, IHomo {

            public void Breakfast() { }
            public void Dinner() { }
            public void Supper() { 
                    Console.WriteLine("я нечего не ел");
            
            }

        }


    }
}
