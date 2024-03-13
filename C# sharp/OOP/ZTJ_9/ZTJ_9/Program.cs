using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTJ_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string st = "Кожахан Е.С";
            string[] sf = st.Split(new Char[] { ' ', '.' });
            foreach (string i in sf)
                Console.WriteLine(i);
            
            
            
            /*string st = "Кожахан Е.С";
            Console.WriteLine(st.Length);*/










        }
    }
}
