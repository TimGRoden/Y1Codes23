using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W102_Switch
{
    internal class W102
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Please enter an integer from 1 to 5 (inclusive)");
            int userNum = int.Parse(Console.ReadLine());
            switch (userNum)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                default: 
                    Console.WriteLine("Invalid number entered");
                    break;
            }

            //Question 2
            Console.WriteLine("What will the weather be like today? ('sunny', 'windy', 'wet', 'snowing')");
            string weather = Console.ReadLine();
            switch (weather.ToLower())
            {
                case "wet":
                    Console.WriteLine("It is wet today, so your might want to wear boots.Is it raining ?");
                    if (Console.ReadLine().ToLower() == "yes") Console.WriteLine("You might also want an umbrella.");
                    break;
                case "sunny": Console.WriteLine("Remember to wear suncream."); break;
                case "windy": Console.WriteLine("I'd advise a coat."); break;
                case "snowing": Console.WriteLine("Tobogan time!"); break;
                default: Console.WriteLine("That wasn't one of my options."); break;
            }

            //Question 3
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hello {userName}, what is your favourite colour? (red, green, blue, yellow, pink)");
            switch (Console.ReadLine().ToLower())
            {
                case "red": Console.ForegroundColor = ConsoleColor.Red; break;
                case "green": Console.ForegroundColor = ConsoleColor.Green; break;
                case "blue": Console.ForegroundColor = ConsoleColor.Blue; break;
                case "yellow": Console.ForegroundColor = ConsoleColor.Yellow; break;
                case "pink": Console.ForegroundColor = ConsoleColor.Magenta; break;
                default: 
                    Console.WriteLine("I didn't understand that. Baby pink it is!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }
            Console.WriteLine($"{userName}, here's a treat!");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }
    }
}
