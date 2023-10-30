using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace TestBed
{
    internal class TestBed
    {
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World.");
            Main(new string[2]);
        }
        static void ChangeYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Main(new string[2]);
        }
        static void ChangeGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Main(new string[2]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("select an option:");
            Console.WriteLine("1. Write Hello World");
            Console.WriteLine("2. Change Text to yellow");
            Console.WriteLine("3. Change Text to green");
            Console.WriteLine("4. Exit");
            int userchoice = int.Parse(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    PrintHelloWorld(); break;
                case 2:
                    ChangeYellow(); break;
                case 3:
                    ChangeGreen(); break;
                case 4:
                    break;
            }
            Console.WriteLine("All done");
            Console.ReadKey();

        }
    }
}
