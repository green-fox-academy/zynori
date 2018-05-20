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
            string firstword = Console.ReadLine();
            Console.WriteLine(CreatePalindrome(firstword));
            Console.ReadLine();
            //Create a function named create palindrome following your current language's style guide. It should take a string, create a palindrome from it and then return it.
        }

        static string CreatePalindrome(string word)
        {
            string tempword = word;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                tempword += word[i];
            }
            return tempword;
        }
    }
}
