using System;
using System.IO;

namespace Directory3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("text.txt", FileMode.Create, FileAccess.ReadWrite);
            f.WriteByte(100);
            byte[] x = new byte[100];
            for (byte i = 0; i < 10; i++)
            {
                x[i] = (byte)(10-i);
                f.WriteByte(i);
            }
            f.Write(x, 0, 5);

            byte[] y = new byte[20];
            f.Seek(0, SeekOrigin.Begin);
            f.Read(y, 0, 20);
            foreach (byte elem in y)
            Console.WriteLine(" "+elem);
            Console.WriteLine();
            f.Seek(5,SeekOrigin.Begin);
            int a = f.ReadByte();
            Console.WriteLine(a);
            a = f.ReadByte();
            Console.WriteLine(a);
            Console.WriteLine("Позиция в потоке " + f.Position);
            f.Close();
        }
    }
}
