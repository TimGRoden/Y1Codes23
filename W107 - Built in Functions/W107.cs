using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W107___Built_in_Functions
{
    internal class W107
    {
        static Random rnd = new Random();
        static void Q3()
        {
            Console.Write("Enter a string to encrypt: "); string choice = Console.ReadLine();
            Console.WriteLine("Base encryption: " + CaesarWord(choice));
            Console.WriteLine("Safe encryption: " + CaesarWord(choice, rnd.Next(1, 26)));
        }

        static bool isVowel(char c) => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
        static int countVowels(string inp) => inp.Aggregate(0, (i, c) => i + (isVowel(c)?1:0));
        static string altLetters(string inp, bool even)
        {
            string result = "";
            for (int i = 0; i < inp.Length; i++) result += i % 2 == (even ? 0 : 1) ? inp[i].ToString() : "";
            return result;
        }
        static void Q2()
        {
            Console.Clear(); Console.WriteLine("2. Word Manipulation");
            Console.Write("Enter a word: "); string choice = Console.ReadLine();
            Console.WriteLine($"Odd letters: {altLetters(choice, false)}.");
            Console.WriteLine($"Even letters: {altLetters(choice, true)}.");
            Console.WriteLine($"Backwards: {choice.Reverse()}");
            Console.WriteLine($"{countVowels(choice)} vowels.");
            Console.ReadKey();
        }

        static void Q1()
        {
            Console.Clear(); Console.WriteLine("1. Buit-in Functions: Small programs");
            
            Console.Write("a) Enter a word: "); string userWord = Console.ReadLine();
            Console.Write("Enter a character: "); 
            char userChar = Console.ReadKey().KeyChar; 
            Console.WriteLine();
            Console.WriteLine($"{userChar} is at position {userWord.IndexOf(userChar)}.");
            Console.ReadKey(true);

            Console.Write("b) Enter a phrase: "); string userPhrase = Console.ReadLine();
            Console.WriteLine($"'cat' found at index {userPhrase.IndexOf("cat")}.");
            Console.ReadKey(true);

            Console.WriteLine($"Generating a random ASCII Character\n{(char)rnd.Next(65, 123)}");
            Console.ReadKey(true);

            Console.Write("Please enter a number: "); double userVal = double.Parse(Console.ReadLine());
            Console.WriteLine($"={userVal.ToString("F2")} (2d.p.)");
            Console.ReadKey(true);

            string secretMessage = "";
            int userChoice = 1;
            do
            {
                Console.Write("Enter an ASCII code: "); userChoice = int.Parse(Console.ReadLine());
                secretMessage += (char)userChoice;
            } while (userChoice >= 65 && userChoice <= 122);
            Console.WriteLine("\n" + secretMessage.Substring(0, secretMessage.Length - 1));
            Console.ReadKey(true);

            Console.Write("Please enter a short message: "); string userMessage = Console.ReadLine();
            foreach (char c in userMessage) Console.Write((int)c + " ");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.Write("Please enter a message to encrypt"); userMessage = Console.ReadLine();
            for (int i = 0; i < userMessage.Length - 1; i += 2)
            {
                Console.Write("" + userMessage[i + 1] + userMessage[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static char CaesarChar(char c) => (char)(c == 90 ? 'A' : (c == 122 ? 'a' : (c + 1)));
        static string CaesarWord(string word) => word.Aggregate("", (s, c) => s + CaesarChar(c));
        static string CaesarWord(string word, int n) { for (int i = 0; i < n; i++) word = CaesarWord(word); return word; }
        static void Q0()
        {
            Console.Clear(); Console.WriteLine("0. Character Name");
            Console.Write("What is your first name? ");
            string fName = Console.ReadLine();
            Console.Write("What is your surname? ");
            string sName = Console.ReadLine();
            Console.WriteLine($"I'd suggest the name {fName.ToUpper()[0]}{fName.ToLower().Substring(1,2)}{sName.ToLower().Substring(0, 3)}.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Which question do you want to do?");
            Console.WriteLine("0. Character Name");
            Console.WriteLine("1. Built-in Functions: Small programs");
            Console.WriteLine("2. Word Manipulation");
            Console.WriteLine("3. Encryption");
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
