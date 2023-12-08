using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thong tin sinh vien");
            Console.WriteLine("Ho va ten");
            String hoTen = Console.ReadLine();

            Console.WriteLine("Tuoi");
            int tuoi = int.Parse(Console.ReadLine());

            Console.WriteLine("Ma sinh vien");
            int msv = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red; 
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(hoTen);
            Console.WriteLine(tuoi);
            Console.WriteLine(msv);

            Console.ReadKey(); 
        }
    }
}
