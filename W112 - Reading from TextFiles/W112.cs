using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W112___Reading_from_TextFiles
{
    internal class W112
    {
        static void Do1()
        {
            string[] contents = File.ReadAllLines("Q1.txt");
            foreach (string line in contents)
            {
                if (line != "#") Console.WriteLine(line);
            }
            Console.WriteLine($"Total Useable Lines Found: {contents.Aggregate(0,(n,w)=>n + (w=="#"?0:1))}");
        }
        static void Do2()
        {
            string[] contents = File.ReadAllLines("Q2.txt");
            bool skipping = false; int i = 0;
            while (i < contents.Length)
            {
                string line = contents[i];
                if (skipping)
                {
                    if (line == "#start") skipping = false;
                    i++;
                    continue; //While skipping, just keep skipping.
                }
                if (line[0] == '#')
                {
                    if (line=="#stop") { skipping = true; i++;  continue; }
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), line.Substring(1));
                }
                else Console.WriteLine(line);
                i++;
            }
            Console.ResetColor();
        }
        static void Do3()
        {
            string[] contents = File.ReadAllLines("Q1.txt");
            int spacer = 3 + contents.Aggregate(0, (n, w) => w.Length > n ? w.Length : n);
            Console.Write("Spell"); Console.CursorLeft = spacer; Console.WriteLine("Length");
            foreach (string spell in contents)
            {
                Console.Write(spell); Console.CursorLeft = spacer; Console.WriteLine(spell.Length);
            }
        }
        static void Do4()
        {

        }
        static void Do5()
        {

        }
        static void DoQuestion()
        {
            string[] Qs = { "Skipping Lines", "File interpreter", "Word length" };
            Console.WriteLine("Which question do you want to run?");
            for (int i = 0; i < Qs.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {Qs[i]}");
            }
            char choice;
            bool notValid = true;
            int question = 1;
            while (notValid)
            {
                choice = Console.ReadKey(true).KeyChar;
                try
                {
                    question = int.Parse(choice.ToString());
                    if (question < 1 || question > Qs.Length) throw new Exception();
                    notValid = false;
                }
                catch { }
            }
            Console.Clear();
            switch (question)
            {
                case 1: Do1(); break;
                case 2: Do2(); break;
                case 3: Do3(); break;
                case 4: Do4(); break;
                case 5: Do5(); break;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                DoQuestion();
                Console.ReadKey();
            }

        }
    }
}
