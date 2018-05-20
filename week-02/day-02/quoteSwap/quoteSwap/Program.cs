using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap()
            // Also, print the sentence to the output with spaces in between.
            Console.WriteLine(QuoteSwap(list));
            // Expected output: "What I cannot create I do not understand." 
            Console.ReadLine();
        }
        static string QuoteSwap(List<string> list)
        {
            int index = list.IndexOf("cannot");
            int index2 = list.IndexOf("do");
            string tempElement = list[index];
            list[index] = list[index2];
            list[index2] = tempElement;

            return string.Join(" ", list);
        }
    }
}
