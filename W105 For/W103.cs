using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W105_For
{
    internal class W103
    {
        static void Main(string[] args)
        {
            //Question 1
            //3, 6, 9, ..., 30, 33
            for (int i = 3; i < 34; i += 3) Console.WriteLine(i);
            //10, 9, 8, ... 1,0
            for (int i = 10; i >= 0; i--) Console.WriteLine(i);
            //0, 0.5, 1, 1.5, ...4.5, 5
            for (double i = 0; i <= 5; i += 0.5)
            {
                Console.Write(i);
                if (i != 5) //This will add commas or a full stop to make the sequence appear in one line.
                {
                    Console.Write(", ");
                } else
                {
                    Console.WriteLine(".");
                }
            }
            //1, 4, 9, 16, 25, 36, 49, 64, 81, 100 [[This is one-lined. Uses the '?' operator]]
            for (int i = 1; i <= 10; i++) Console.Write($"{i * i}{((i == 10) ? ".\n" : ", ")}");
            //2, 4, 8, 16, 32, 64, 128, 256, 512, 1024
            for (int i=2; i<=1024;i*=2) Console.Write($"{i}{((i == 10) ? ".\n" : ", ")}");
            //1, 16, 256, 4096
            for (int i=1;i<=int.MaxValue&&i>0;i*=16) Console.Write($"{i}{((i == 268435456) ? ".\n" : ", ")}");
            //With this one, be careful of "wrap around" when you multiply by 16. 268435456 is the last storeable.



            Console.ReadKey();
        }
    }
}
