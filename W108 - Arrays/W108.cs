using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W108___Arrays
{
    internal class W108
    {
        static void Q0()
        {
            Console.Clear(); Console.WriteLine("0. Int Arrays");
            int[] zeroes = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.Write("Array Generated: [");
            for (int i = 0; i < 8; i++) Console.Write(zeroes[i] + (i == 7 ? "]\n" : ","));
        }
        static void Q1() 
        {
            Console.Clear(); Console.WriteLine("1. Names");
            string[] names = { "Ethan", "Jim", "Reece", "Misha", "Will" };
            foreach (string name in names) Console.WriteLine(name);
            names.Reverse();
            foreach (string name in names) Console.WriteLine(name);
        }
        static void Q2()
        {
            Console.Clear(); Console.WriteLine("2. User Entered Ints");
            int[] userNums = new int[10];
            Console.WriteLine("Please enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}. ");
                userNums[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Array Generated: [");
            for (int i = 0; i < 8; i++) Console.Write(userNums[i] + (i == 7 ? "]\n" : ","));
            Console.WriteLine($"Sum: {userNums.Aggregate(0, (s, i) => s + i)}");
            double average = (double)userNums.Aggregate(0, (s, i) => s + i) / userNums.Length;
            Console.WriteLine($"Mean: {average}");
            foreach (int num in userNums) Console.WriteLine($"{num} is {(num > average ? "above " : num == average ? "equal to " : "below ")} the average.");
            Console.WriteLine($"{userNums.Aggregate(0,(c,i)=>i>average?c+1:c)} numbers are above the average.");
        }
        static void Q3() 
        {
            Console.Clear(); Console.WriteLine("3. Dice recorder");
            Console.WriteLine("How many sides does the dice have?");
            int sides = int.Parse(Console.ReadLine());
            int[] results = new int[sides];
            for (int i = 1; i < sides; i++)
            {
                Console.WriteLine($"How many times was a {i} rolled?");
                results[i-1] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("I've got the following results:");
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"{i+1} was {(results[i]==0?"not rolled.":results[i]==1?"rolled 1 time":$"rolled {results[i]} times")}.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Which question do you want to do?");
            Console.WriteLine("0. Int Arrays");
            Console.WriteLine("1. Names");
            Console.WriteLine("2. User Entered Ints");
            Console.WriteLine("3. Dice Recorder");
            switch (Console.ReadKey().KeyChar)
            {
                case '0': Q0(); break;
                case '1': Q1(); break;
                case '2': Q2(); break;
                default: Q3(); break;
            }
            Console.ReadKey();
        }
    }
}
