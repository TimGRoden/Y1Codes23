using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
       
        static int findMaxL(string[] words)
        {
            int maxL = 0;
            foreach (string word in words)
            {
                if (word.Length > maxL) maxL = word.Length;
            }
            return maxL;
        }
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream("Spells.txt", FileMode.OpenOrCreate)))
            {
                sw.WriteLine("Gust");
                sw.WriteLine("Thunderwave");
                sw.WriteLine("Prestiditigation");
                sw.WriteLine("Virtue");
                sw.WriteLine("Knock");
                sw.WriteLine("Guidance");
            }

            string[] spells = File.ReadAllLines("Spells.txt");
            Console.Write($"Spells");
            int spacer = findMaxL(spells) + 3;
            Console.CursorLeft = spacer;
            Console.WriteLine("Length");
            Console.WriteLine();
            foreach (string spell in spells)
            {
                Console.Write(spell);
                Console.CursorLeft = spacer;
                Console.WriteLine(spell.Length);
            }
            Console.ReadKey();
        }
    }
}

