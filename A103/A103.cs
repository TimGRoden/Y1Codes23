using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A103
{
    internal class A103
    {
        static void Q1()
        {
            Console.Clear();
            Console.Write("Please enter a positive integer: ");
            int userNum = int.Parse(Console.ReadLine());
            int printVal = 0;
            while (printVal <= userNum)
            {
                Console.WriteLine(printVal);
                printVal++;
            }
        }
        static void Q2()
        {
            Console.Clear();
            Console.WriteLine("Enter the power table you would like to see:");
            int powerTable = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the highest power:");
            int maxPower = int.Parse(Console.ReadLine());
            for (int i = 0; i < maxPower; i++)
            {   //If i is even, print in Grey, if not print in Cyan (as in the example)
                if (i % 2 == 0) Console.ForegroundColor = ConsoleColor.Gray;
                else Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{powerTable} ^ {i}{new string(' ', maxPower.ToString().Length + 1 - i.ToString().Length)}= {Math.Pow(powerTable, i)}");
            }                                          //This makes a number of spaces based on the max necessary spaces, plus 1.
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Which program are you running? 1 or 2?");
            switch (Console.ReadKey(true).KeyChar) 
            {
                case '1': Q1(); break;
                default: Q2(); break;
            }
            Console.ReadKey();
        }
    }
}
