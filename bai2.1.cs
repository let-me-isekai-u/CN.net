using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maxNum = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);

            Console.WriteLine($"Max = {maxNum}");
            Console.ReadKey();


        }
    }
}
