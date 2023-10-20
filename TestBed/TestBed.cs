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
        static void RandPass()
        {
            string password = "";
            Random rnd = new Random();
            Console.WriteLine("What is your first name?");
            string dummy = Console.ReadLine().ToUpper();
            password += dummy[rnd.Next(0, dummy.Length)];
            Console.WriteLine("What is your surname?");
            dummy = Console.ReadLine().ToUpper();
            password += dummy[rnd.Next(0, dummy.Length)];
            Console.WriteLine("What is your birth year?");
            password += Console.ReadLine().Substring(rnd.Next(0, 2), 2);
            Console.WriteLine("What is your favourite colour?");
            dummy = Console.ReadLine().ToLower();
            int a = rnd.Next(0, dummy.Length);
            int b;
            do
            {
                b = rnd.Next(0, dummy.Length);
            } while (a == b);
            password += dummy[a];
            password += dummy[b];
            Console.WriteLine("What street do you live on?");
            dummy = Console.ReadLine();
            password += dummy.Substring(rnd.Next(0, dummy.Length - 2), 3);
            Console.WriteLine("What is your shoesize?");
            dummy = Console.ReadLine();
            password += dummy[rnd.Next(0, dummy.Length)];
            dummy = "";
            Console.WriteLine($"Password generated: {password}");
        }
        static void SafePass()
        {
            string password = "";
            Console.WriteLine("What is your first name?");
            password += Console.ReadLine().ToUpper()[0];
            Console.WriteLine("What is your surname?");
            password += Console.ReadLine().ToUpper()[1];
            Console.WriteLine("What is your birth year?");
            password += Console.ReadLine().Substring(2, 2);
            Console.WriteLine("What is your favourite colour?");
            password += Console.ReadLine().Substring(1, 2);
            Console.WriteLine("What street do you live on?");
            password += Console.ReadLine().Substring(0, 3);
            Console.WriteLine("What is your shoesize?");
            password += Console.ReadLine()[0];
            Console.WriteLine($"Password generated: {password}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Which Password generator? (1,2)");
            if (Console.ReadKey(true).KeyChar == '1') RandPass();
            else SafePass();

            Console.ReadKey();

        }
    }
}
