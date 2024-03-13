using System;

namespace string4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "world";
            string s3 = s1 + " " + s2;
            string s4 = String.Concat(s3, "!!!");

            Console.WriteLine(s4);
        }
    }
}
