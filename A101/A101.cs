using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A101
{
    internal class A101
    {
        static void larger(int first, int second) => Console.WriteLine(first > second ? "first" : first!=second?"second":"");
        static void selector(int userNum) => Console.WriteLine(userNum > 5000 ? "Too big" : userNum < 1000 ? "Too small" : "Correct!");
        static double pizzaEaten(double diam, int slices, int eaten) => Math.PI * diam * diam * 0.25 * 2 * eaten / slices;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two integers:");
            larger(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter a number:");
            selector(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the diameter:");
            double diam = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the total number of slices per pizza:");
            int total = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of slices eaten:");
            int slices = int.Parse(Console.ReadLine()); 
            Console.WriteLine($"{pizzaEaten(diam, total, slices).ToString("F2")}cm^3 of pizza eaten.");


            Console.ReadKey();
        }
    }
}
