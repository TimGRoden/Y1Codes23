using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A102
{
    internal class A102
    {
        static void Q1()
        {
            Console.WriteLine("What colour is the current traffic light?");
            switch (Console.ReadLine().ToLower())
            {
                case "red": Console.WriteLine("RedAmber"); break;
                case "redamber": Console.WriteLine("Green"); break;
                case "green": Console.WriteLine("Amber"); break;
                case "amber": Console.WriteLine("Red"); break;
            }
        }
        static bool AskQuestion(string question, string answer)
        {
            Console.WriteLine(question);
            if (Console.ReadLine().ToLower() == answer.ToLower())
            {
                Console.WriteLine("Correct!");
                return true;
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer was '{answer}'.");
                return false;
            }
        }
        static void Q2()
        {
            int score = 0;
            if (AskQuestion("What is the capital of England?", "London")) score++;
            if (AskQuestion("What is the capital of Scotland?", "Edinburgh")) score++;
            if (AskQuestion("What is the capital of Wales?", "Cardiff")) score++;
            Console.WriteLine($"Quiz over. You've scored {score}/3.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Which program do you want to run?");
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': Q1(); break;
                case '2': Q2(); break;
            }
            Console.ReadKey();
        }
    }
}
