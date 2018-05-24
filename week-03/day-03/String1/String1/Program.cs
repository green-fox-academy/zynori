using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputword = Console.ReadLine();
            Console.WriteLine(ReplaceChars(inputword));
            Console.ReadLine();
        }

        public static string ReplaceChars(string inputWord)
        {
            string replacedWord = inputWord;

            if (replacedWord.Length <= 0)
            {
                return replacedWord;
            }
            else if (replacedWord.Contains("x"))
            {
                return replacedWord = ReplaceChars(replacedWord.Replace("x", "y"));
            }
            else
            {
                return replacedWord;
            }
        }
    }
}
// Given a string, compute recursively (no loops) a new string where all the
// lowercase 'x' chars have been changed to 'y' chars.