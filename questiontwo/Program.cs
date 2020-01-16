using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace questiontwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your input");
            var pilandrome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(pilandrome))
            {
                throw new ArgumentException("Input cannot be null or empty");
            }

            Console.WriteLine(string.Format("Is string a Palindrome?: {0}", IsPalindrome(pilandrome)));

            Console.ReadKey();
        }
        public static bool IsPalindrome(string inputString)
        {
            char[] inputArray = inputString.ToLowerInvariant().Where(char.IsLetter).ToArray();
            int len = inputArray.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (inputArray[i] != inputArray[len - (i + 1)])
                    return false;
            }
            return true;
        }
    }
}

