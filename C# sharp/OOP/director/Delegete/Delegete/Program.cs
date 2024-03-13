using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegete
{
    public delegate int Calculate(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = calsquare;
            Console.WriteLine("Результат делегата(квадрат) {0}", cal(5));

            cal = calcube;
            Console.WriteLine("Результат делегата(куб) {0}",cal(5));
        }
        static int calsquare(int x)
        {
            return x * x;
        }
        static int calcube(int x) { return x * x * x; }
    }
}
