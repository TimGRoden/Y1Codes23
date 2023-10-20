using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W104___While
{
    internal class W104
    {
        static void Q1()
        {
            Console.Clear(); Console.WriteLine("1. Basics");
            int x = 0;

            while (x>0) //As x starts at 0, this loop works immediately like this.
            {
                Console.Write("Enter number: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine(x);
            }

            Console.WriteLine("DONE");
            Console.ReadKey();

        }
        static void Q2()
        {
            string truePin = "11235813"; //The fibonacci numbers!
            int attempts = 0;
            Console.Clear(); Console.WriteLine("2. Cash Machine");
            while (attempts != 3)
            {
                Console.WriteLine("Please enter your 8 digit PIN:");
                string userPin = Console.ReadLine();
                if (userPin == truePin)
                {
                    Console.WriteLine("Welcome to the C# Bank."); break;
                } else
                {
                    attempts ++;
                    if (attempts < 3) Console.WriteLine($"Incorrect pin, you have {3 - attempts} attempts left.");
                    else Console.WriteLine("Incorrect pin. You have been locked out of this account.");
                }
            }

        }
        static void Q3()
        {
            Console.Clear(); Console.WriteLine("3. Class Counter");
            Console.WriteLine("Please enter members of the class one at a time. Enter '.' when finished.");
            int items = -1;
            string lastItem;
            do
            {
                items++;
                Console.Write($"{items + 1}. "); //Makes a nice ordered list.
                lastItem = Console.ReadLine();
            } while (lastItem != ".");
            Console.CursorTop--; //Overwrites the '.' row.
            Console.WriteLine($"Completed class list. You have entered {items} names.");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Which question do you want to do?");
            Console.WriteLine("1. Basics");
            Console.WriteLine("2. Cash Machine");
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
