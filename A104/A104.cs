using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A104
{
    internal class A104
    {
        static Random rnd = new Random();
        static void Q1()
        {
            Console.WriteLine("Welcome to the n sided die.\n");
            Console.WriteLine("How many sides would you like your die to have?");
            int uSides = int.Parse(Console.ReadLine());
            Console.WriteLine("\nHow many times would you like to roll your die?");
            int uRolls = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nhere are your rolls:");
            Console.WriteLine(roll(uSides, uRolls));
        }
        static void Q2()
        {
            Console.WriteLine("Welcome to Sum or Factorial\n");
            Console.WriteLine("Enter a number");
            int userNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Would you like to sum all numbers up to 5 or find the factorial of the number?");
            switch (getUserChoice())
            {
                case 's': Console.WriteLine($"Sum of all numbers up to {userNum} = {calcSum(userNum)}"); break;
                case 'f': Console.WriteLine($"Factorial of {userNum} = {calcFact(userNum)}"); break;
            }
            
            Console.WriteLine("bye!");
        }
        static char getUserChoice()
        {
            char result;
            do 
            {
                Console.WriteLine("Enter s for sum and f for factorial"); 
                result = Console.ReadKey().KeyChar; 
            } while (result != 's' && result != 'f');
            return result;
        }
        static int calcSum(int n) => n == 0 ? 0 : (n + calcSum(n - 1));
        static int calcFact(int n) => n == 1 ? 1 : (n * calcFact(n - 1));
        static string roll(int sides, int n) => n == 0 ? "\n" : $"{rnd.Next(1,sides+1)}\n{roll(sides, n-1)}";
        static void Main(string[] args)
        {
            Console.WriteLine("Which question? (1/2)");
            char userChoice = Console.ReadKey(true).KeyChar;
            Console.Clear();
            switch (userChoice)
            {
                case '1': Q1(); break;
                default: Q2(); break;
            }
            Console.ReadKey();
        }
    }
}
