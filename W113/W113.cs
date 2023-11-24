using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace W113
{
    internal class W113
    {
        static void Q1()
        {
            const string filename = "MyFile.txt";

            Console.Clear();
            Console.WriteLine("Adding \"Hello World\" to the text file with a WriteAllText.");
            File.WriteAllText(filename, "Hello World");
            Console.ReadKey();
            Console.WriteLine("Now adding \"Hello World\" to the text file with a StreamWriter.");
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine("Hello World");
            }
            Console.ReadKey();
        }
        static void Q2()
        {
            Console.Clear();
            const string filename = "OneToOneHundred.txt";
            Console.WriteLine($"Writing the numbers 1 to 100 into the text file '{filename}'.");
            string text = "";
            for (int i=1; i <= 100; i++)
            {
                text += i.ToString() + ", ";
                if (i % 10 == 0 && i!=1) text += "\r\n";
            }
            File.WriteAllText(filename, text);
            Console.WriteLine($"Writen the numbers into the text file '{filename}'.");
        }
        static void Q3()
        {
            Console.Clear();
            Console.WriteLine("What is the name of your text file?");
            string filename = Console.ReadLine();
            if (filename.Substring(filename.Length - 4, 4) != ".txt") filename += ".txt";

            using (StreamWriter writer = new StreamWriter(filename))
            {
                
                Console.WriteLine("Please enter a lines of text to input. Press enter without text on a line to end text input.");
                string userLine = Console.ReadLine();
                while (userLine != "")
                {
                    writer.WriteLine(userLine);
                    userLine = Console.ReadLine();
                }
            }
            Console.WriteLine($"Completed text input for file '{filename}'.");
            Console.ReadKey();
        }
        static void Q4()
        {
            Console.Clear();
            const string filename = "q4file.txt";
            while (true)
            {
                Console.WriteLine($"Please enter a line to scan the text file '{filename}'for.");
                string userInput = Console.ReadLine();
                string[] lines = File.ReadAllLines(filename);
                if (!lines.Contains(userInput))
                {
                    Console.WriteLine($"Could not find '{userInput}' in the file '{filename}'.");
                    using (StreamWriter sw = new StreamWriter(filename, true))
                    {
                        sw.WriteLine(userInput);
                    }
                    Console.WriteLine("It has now been added to the file.");
                }
                else Console.WriteLine($"That word is in the file '{filename}' on line {Array.IndexOf(lines, userInput) + 1}.");
                Console.WriteLine("Would you like to check another word? (Y/N)");
                if (Console.ReadKey(true).KeyChar.ToString().ToLower() != "y") break;
            }
            Console.ReadKey();
        }
        static void DoQuestion()
        {
            Dictionary<char, string> Options = new Dictionary<char, string>
            {
                { '1', "Q0, Basics" },
                { '2', "Q1, Hundred" },
                { '3',"Q2, Message"},
                { '4',"Q3, File Checker"}
            };
            Console.WriteLine("Which question do you want to do?");
            foreach (char key in Options.Keys)
            {
                Console.WriteLine($"{key}: {Options[key]}");
            }
            char userChoice = ' ';
            do
            {
                userChoice = Console.ReadKey(true).KeyChar;
                if (!Options.Keys.Contains(userChoice)) Console.WriteLine("Invalid choice, try again.");
            } while (!Options.Keys.Contains(userChoice));
            switch (userChoice)
            {
                case '1': Q1(); break;
                case '2': Q2(); break;
                case '3': Q3(); break;
                case '4': Q4(); break;
                default: break;
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                DoQuestion();
            }
        }
    }
}
