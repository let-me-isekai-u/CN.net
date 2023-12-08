using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            Console.WriteLine("Enter r");
            double r = double.Parse(Console.ReadLine());

            double P = 2 * PI * r;
            double S = PI * r * r;
            Console.WriteLine($"Cir = {P}");
            Console.WriteLine($"Area = {S}");

            Console.ReadKey();

        }
    }
}
