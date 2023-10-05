using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W105_Random_Numbers
{
    internal class W105
    {
        static Random rnd = new Random();
        static void Q1()
        {
            Console.WriteLine($"Random integer from 1 to 10: {rnd.Next(1, 11)}");
            Console.WriteLine($"Coinflip: {(rnd.NextDouble() > 0.5 ? "Heads!" : "Tails!")}");
            Console.Write("1 - 30: ");
            for (int i = 0; i < 20; i++) Console.Write(rnd.Next(1, 31) + (i == 19 ? "\n" : ", "));
            Console.Write("51 - 60: ");
            for (int i = 0; i < 20; i++) Console.Write(rnd.Next(51, 61) + (i == 19 ? "\n" : ", "));
            Console.Write("Even numbers between 0 - 10: ");
            for (int i = 0; i < 20; i++) Console.Write(2*rnd.Next(0, 6) + (i == 19 ? "\n" : ", "));
            Console.Write("Odd numbers between 1 - 11: ");
            for (int i = 0; i < 20; i++) Console.Write((2*rnd.Next(1, 6)+1) + (i == 19 ? "\n" : ", "));
            Console.Write("Sums of powers of 3 and 5 up to 3^4 + 5^4: ");
            for (int i = 0; i < 20; i++) Console.Write((Math.Pow(3,rnd.Next(1, 5))+ Math.Pow(5, rnd.Next(1, 5))) + (i == 19 ? "\n" : ", "));
            Console.Write("Numbers between 0 and 1 to 2d.p.: ");
            for (int i = 0; i < 20; i++) Console.Write((String.Format("{0:0.00}",rnd.NextDouble())) + (i == 19 ? "\n" : ", "));
        }
        static void Q2()
        {
            Console.WriteLine("How many dice do you want to roll?");
            int noDice = int.Parse(Console.ReadLine());
            Console.WriteLine("How many sides do these dice have?");
            int diceSides = 0;
            while (diceSides < 1)
            {
                diceSides = int.Parse(Console.ReadLine());
            }
            int[] results = new int[noDice];
            for (int i = 0; i < noDice; i++)
            {
                results[i] = rnd.Next(1, diceSides + 1);
                Console.Write(results[i] + (i == noDice - 1 ? "\n" : ", "));
            }
            Console.WriteLine($"Total is {results.Aggregate(0, (m, i) => m += i)}.");
            Console.WriteLine($"Matt says this is easier: {results.Sum()}.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Which question?");
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': Q1(); break;
                case '2': Q2(); break;
            }
            Console.ReadKey();
        }
    }
}
