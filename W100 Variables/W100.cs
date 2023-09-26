using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W100_Variables
{
    internal class W100
    {
        static void Main(string[] args)
        {
            // Question 1:
            // Part a:
            string favouriteSubject = "Computer Science";
            Console.WriteLine($"I love {favouriteSubject}!");
            // Part b:
            Console.WriteLine("Please enter two whole numbers:");
            int number_1 = int.Parse(Console.ReadLine());
            int number_2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number_1} + {number_2} = {number_1 + number_2}");

            // Question 2:
            Console.WriteLine("What is the name of your team?");
            string userTeam = Console.ReadLine();
            Console.WriteLine("How many wins?");
            int winCount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many draws?");
            int drawCount = int.Parse(Console.ReadLine());
            Console.WriteLine($"Total points for {userTeam} is {3*winCount + drawCount}");

            //Question 3:
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter a number between 1 and 12:");
            int table = int.Parse(Console.ReadLine());
            Console.WriteLine($"{userName}, the times table for {table} is:");
            Console.WriteLine($" 1 * {table} = {1 * table}");
            Console.WriteLine($" 2 * {table} = {2 * table}");
            Console.WriteLine($" 3 * {table} = {3 * table}");
            Console.WriteLine($" 4 * {table} = {4 * table}");
            Console.WriteLine($" 5 * {table} = {5 * table}");
            Console.WriteLine($" 6 * {table} = {6 * table}");
            Console.WriteLine($" 7 * {table} = {7 * table}");
            Console.WriteLine($" 8 * {table} = {8 * table}");
            Console.WriteLine($" 9 * {table} = {9 * table}");
            Console.WriteLine($"10 * {table} = {10 * table}");
            Console.WriteLine($"11 * {table} = {11 * table}");
            Console.WriteLine($"12 * {table} = {12 * table}");

            //Question 4:
            Console.WriteLine("Please enter the radius of your circle:");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of that circle is {(Math.PI*radius*radius).ToString("F2")}.");
            Console.WriteLine("How tall is your cylinder?");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"That cylinder's surface area is {(2 * Math.PI * radius * (radius + height)).ToString("F2")}.");
            Console.WriteLine($"The cylinder's volume is {(Math.PI * radius * radius * height).ToString("F2")}.");


            Console.ReadKey();
        }
    }
}
