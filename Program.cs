using System;
using System.Linq;

namespace TestConsoleApp
{
    internal class Program
    {
        public static bool IsPrimeNumber(int number)
        {
            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0)
                    return false;
            return true;
        }
        public static void NumberofDigits(int number)
        {
            int counter = 0;
            while (number > 0)
            {
                number = number / 10;
                counter++;
            }
            Console.WriteLine("The number of digits is:" + counter);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String: ");
            int number = Convert.ToInt32(Console.ReadLine());
            NumberofDigits(number);
            Console.ReadKey();
        }

        private static void FindShortestWord(string text)
        {
            text = String.Concat(text.Where(u => char.IsLetterOrDigit(u) || char.IsWhiteSpace(u))).ToLower();
            string[] words = text.Split(' ');
            string shortestWord = words[0];
            int shortestWordLength = words[0].Length;
            foreach (var word in words)
            {
                if (word.Length < shortestWordLength)
                {
                    shortestWord = word;
                    shortestWordLength = word.Length;
                }
            }
            Console.WriteLine("The Shortest Word is: " + shortestWord);
        }

        private static void FindLongestWord(string text)
        {
            text = String.Concat(text.Where(u => char.IsLetterOrDigit(u) || char.IsWhiteSpace(u))).ToLower();
            string[] words = text.Split(' ');
            string longestWord = words[0];
            int longestWordLength = words[0].Length;
            foreach (var word in words)
            {
                if (word.Length > longestWordLength)
                {
                    longestWord = word;
                    longestWordLength = word.Length;
                }
            }
            Console.WriteLine("The Longest Word is: " + longestWord);
        }
    }
}
