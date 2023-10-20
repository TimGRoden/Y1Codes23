using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W106___Procedures_with_Parameters
{
    internal class W106
    {
        static void Q1()
        {
            Console.Clear(); Console.WriteLine("1. Basics");
            Console.WriteLine("Please enter two numbers:");
            MyAdd(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
        static void Q2()
        {
            Console.Clear(); Console.WriteLine("2. Display Symbols");
            string userSymbol = "*";
            int across = 3;
            DisplaySymbols(userSymbol, across);
            Console.WriteLine();
            DisplayRectangle("%", 4, 3);

        }
        static void DisplayText(string text, ConsoleColor color = ConsoleColor.White)
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = old;
        }
        static void Q3()
        {
            Console.Clear(); Console.WriteLine("2. Menu");
            Console.WriteLine("Please enter a sentence:");
            string userString = Console.ReadLine();
            Console.WriteLine(@"Please select from:
1. Display the sentence
2. Display sentence in cyan text
3. Display sentence in magenta text");
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': DisplayText(userString); break;
                case '2': DisplayText(userString, ConsoleColor.Cyan); break;
                default: DisplayText(userString, ConsoleColor.Magenta); break;
            }

        }
        static void DisplaySymbols(string userSymbol, int across)
        {
            Console.WriteLine(new string(userSymbol[0], across)); //userSymbol should only be one char.
        }
        static void DisplayRectangle( string text, int width, int height)
        {
            for (int i = 0; i < height; i++) DisplaySymbols(text, width);
        }
        static void MyAdd(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Which question do you want to do?");
            Console.WriteLine("1. Basics");
            Console.WriteLine("2. Display Symbols");
            Console.WriteLine("3. Class Counter");
            switch (Console.ReadKey().KeyChar)
            {
                case '1': Q1(); break;
                case '2': Q2(); break;
                default: Q3(); break;
            }
            Console.ReadKey();
        }
    }
}
