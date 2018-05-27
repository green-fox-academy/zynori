using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI"; 

            Console.WriteLine(Reverse(reversed));
            Console.ReadLine();
        }

        public static string Reverse(string reversed)
        {
            string reverse = "";

            for (int i = reversed.Length - 1; i >= 0; i--)
            {
                reverse += reversed[i];
            }

            return reverse;
        }
    }
}
// Create a method that can reverse a String, which is passed as the parameter
// Use it on this reversed string to check it!