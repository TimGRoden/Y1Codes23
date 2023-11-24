using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W110___Custom_Functions
{
    internal class W110
    {
        static int addTwo(int num1, int num2) => num1 + num2;
        static int biggest(int num1, int num2) => Math.Max(num1, num2);
        static bool isOdd(int num) => num % 2 == 1;
        static bool isPrime(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        static double yearsToSeconds(double years) => 31536000 * years;
        static int factorial(int num) => (num <= 1 ? 1 : (num * factorial(num - 1)));
        static string initials() => Console.ReadLine().Split(' ').Aggregate("", (a, b) => a + b.ToUpper()[0] + ". ");

        static string GenerateUsername(string forename, string surname, int year)
            => "xX_" + forename.ToLower()[0] + surname.ToLower() + year.ToString() + "_Xx";
        static bool isTooLong(string line) => line.Length >= Console.WindowWidth;
        static void WriteWide(string line)
        {
            if (!isTooLong(line))
            {
                Console.WriteLine(line);
                return;
            }
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i] + (i % Console.WindowWidth == 0 ? "\n" : ""));
            }
            Console.WriteLine();
        }
        static double QuadraticEval(double[] coeffs, double x) => coeffs[0] * (Math.Pow(x, 2)) + coeffs[1] * x + coeffs[2];
        static double[] QuadraticSolve(double[] coeffs)
        {
            double disc = coeffs[1] * coeffs[1] - 4 * coeffs[0] * coeffs[2];
            if (disc == 0) return new double[] { -coeffs[1] / (2 * coeffs[0]) };
            else if (disc < 0) return new double[] { };
            double sqrt = Math.Sqrt(disc);
            return new double[] { (-coeffs[1] + disc) / (2 * coeffs[0]), (-coeffs[1] - disc) / (2 * coeffs[0]) };
        }
        static string BinaryConverter(int num) 
        {
            string result = "";
            while (num > 0)
            {
                result = (num % 2 == 0 ? "0" : "1") + result;
                num /= 2;
            }
            return result;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
