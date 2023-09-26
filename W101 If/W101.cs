using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace W101_If
{
    internal class W101
    {
        static void Main(string[] args)
        {
            // Question 1
            Console.WriteLine("Please enter a whole number");
            int userNum = int.Parse(Console.ReadLine());
            if (userNum > 100) Console.WriteLine("Too big.");
            else if (userNum < 1) Console.WriteLine("Too small.");
            else Console.WriteLine("That's between 1 and 100.");

            // Question 2
            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine($"You are {(userAge < 18 ? "too young" : "old enough")} to drive.");

            //Question 3
            Console.WriteLine("Please enter three numbers.");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double largest;
            if (num1 > num2 && num1 > num3) largest = num1;
            else if (num2 > num3) largest = num2; //If num1 isn't largest, num2 or 3 is. Only check them!
            else largest = num3; //This will also catch if all three are the same.
            Console.WriteLine($"The largest number was {largest}.");

            //Question 3
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What subject did you assess?");
            string subject = Console.ReadLine();
            Console.WriteLine("What score did you get in the test?");
            double userScore = int.Parse(Console.ReadLine()); //Storing this in a double allows us to calculate the percentage.
            Console.WriteLine("What was it out of?");
            int totalScore = int.Parse(Console.ReadLine());
            double percentage = userScore / totalScore * 100;
            string grade;
            if (percentage > 90) grade = "A*";
            else if (percentage > 80) grade = "A";
            else if (percentage > 70) grade = "B";
            else if (percentage > 60) grade = "C";
            else if (percentage > 50) grade = "D";
            else if (percentage > 40) grade = "E";
            else grade = "U";
            Console.WriteLine($"{userName}, {subject}, {userScore}/{totalScore}, {percentage.ToString("F0")}%, grade {grade}.");


        }
    }
}
