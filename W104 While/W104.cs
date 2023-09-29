using System;

namespace W104_While
{
    internal class W104
    {
        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        int x = 0;

                        do //Do the code once, before the conditional check.
                        {
                            Console.Write("Enter number: ");
                            x = int.Parse(Console.ReadLine());
                            Console.WriteLine(x);
                        } while (x > 0);

                        Console.WriteLine("DONE");
                        Console.ReadKey();


                        x = 0;

                        while (x > 0) //Just check x at the start, as it's already 0.
                        {
                            Console.Write("Enter number: ");
                            x = int.Parse(Console.ReadLine());
                            Console.WriteLine(x);
                        }

                        Console.WriteLine("DONE");
                        Console.ReadKey();
                    }break;
                case "2":
                    {
                        int attempts = 0;
                        string realPin = "1123";
                        while (attempts < 3)
                        {
                            Console.WriteLine("Please enter a pin.");
                            string userPin = Console.ReadLine();
                            if (userPin == realPin)
                            {
                                Console.WriteLine("That's right! Welcome.");
                                break;
                            }
                            Console.WriteLine("That wasn't right. Please try again.");
                            Console.WriteLine($"You have {3 - attempts} attempts left.");
                            attempts++;
                        }
                    }break;
            }



        }
    }
}
