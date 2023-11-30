using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W111___Structures
{
    internal class W111
    {
        struct Person
        {
            public string title, forename, surname;
            public ConsoleColor favouriteColour;
            public int age;
        }
        static void Do1()
        {
            Person myself;
            myself.title = "Lord";
            myself.forename = "Tim"; myself.surname = "Roden";
            myself.age = 1443; myself.favouriteColour = ConsoleColor.Magenta;
            DisplayPerson(myself);
        }
        static void DisplayPerson(Person person) {
            Console.ForegroundColor = person.favouriteColour;
            Console.WriteLine($"Greetings {person.title} {person.forename} {person.surname}. How does it feel to be {person.age}?");
            Console.ResetColor();
        }
        struct Car
        {
            public string colour, make, model;
            public double value;
        }
        static void Do2()
        {
            Car myCar;
            myCar.colour = "blue-grey"; myCar.make = "Ford"; myCar.model = "Focus"; myCar.value = 10000.99;
            Console.WriteLine($"myCar is a {myCar.colour} {myCar.make} {myCar.model}, valued at ${myCar.value.ToString("F2")}");
            Car yourCar;
            yourCar.colour = "Red"; yourCar.make = "Venturi"; yourCar.model = "400 GT"; yourCar.value = 70000.20;
            Console.WriteLine($"yourCar is a {yourCar.colour} {yourCar.make} {yourCar.model}, valued at ${yourCar.value.ToString("F2")}");
        }
        struct Point { public int x, y; }
        static void Do3()
        {
            Random rnd = new Random();
            for (int i=0;i<40; i++)
            {
                Point p;
                p.x = rnd.Next(Console.WindowWidth);
                p.y = rnd.Next(Console.WindowHeight);
                PlotX(p);
                System.Threading.Thread.Sleep(100);
            }
        }
        static void PlotX(Point p)
        {
            Console.SetCursorPosition(p.x, p.y);
            Console.Write('X');
            Console.SetCursorPosition(0, 0);
        }
        static void Do4()
        {

        }
        static void Do5()
        {

        }
        static void DoQuestion()
        {
            string[] Qs = { "Personal Data", "Cars", "Coordinates" };
            Console.WriteLine("Which question do you want to run?");
            for (int i=0;i<Qs.Length;i++)
            {
                Console.WriteLine($"{i+1}: {Qs[i]}");
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
