using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBed
{
    internal class TestBed
    {

        static void Main(string[] args)
        {
            Console.WriteLine("How many rows do you want?");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(new string(' ', rows - i - 1) + new string('*', (i + 1) * 2));
            }

            Console.ReadKey();
        }
    }
}
