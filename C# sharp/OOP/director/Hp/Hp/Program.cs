using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Hp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[]drives=DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine(@"Atauy: " +  drive.Name);
                Console.WriteLine(@"Tipy:" + drive.DriveType);
                if (drive.IsReady)
                {
                    Console.WriteLine(@"Disk kolemi:" + drive.TotalSize);
                    Console.WriteLine(@"Bos kenestik:" + drive.TotalFreeSpace);
                    Console.WriteLine(@"Belgi:" + drive.VolumeLabel);
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
