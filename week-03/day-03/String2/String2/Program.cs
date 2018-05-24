using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            Console.WriteLine(RemovingChars(inputWord));
            Console.ReadLine();
        }

        public static string RemovingChars(string inputWord)
        {
            string removedWord = inputWord;

            if (removedWord.Length == 0)
            {
                return removedWord;
            }
            else if (removedWord.Contains("x"))
            {
                return removedWord = RemovingChars(inputWord.Replace("x", ""));
            }
            else
            {
                return removedWord;
            }
        }
    }
}
// Given a string, compute recursively a new string where all the 'x' chars have been removed.