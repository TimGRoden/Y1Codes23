using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A100
{
    internal class A100
    {

        static void printOut(int num1, int num2) => Console.WriteLine($"{num1} + {num2} = {num1 + num2}\n{num1} * {num2} = {num1 * num2}\n({num1} + {num2})^2 = {Math.Pow(num1+num2,2)}");
        static void slabCost(int width, int depth, double price) => Console.WriteLine($"Total price is: ${(width * depth * price).ToString("F2")}");
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers:");
            printOut(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the number of slabs across:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of slabs deep:");
            int depth = int.Parse(Console.ReadLine());
            Console.Write("Enter the price of a slab:\n£");
            double price = double.Parse(Console.ReadLine());
            slabCost(width, depth, price);

            Console.ReadKey();
        }
    }
}
