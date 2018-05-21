using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function named create palindrome following your current language's style guide. It should take a string, create a palindrome from it and then return it.
            string inputWord = Console.ReadLine();
            Console.WriteLine(CreatePalindrome(inputWord));
            Console.ReadLine();
        }

        static string CreatePalindrome(string inputWord)
        {
            string result = inputWord;

            for (int i = inputWord.Length -1; i >= 0; i--)
            {
                result += inputWord[i];
            }

            return result;
        }
    }
}
