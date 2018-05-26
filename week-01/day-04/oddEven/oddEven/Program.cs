using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me a number:");
            int number = int.Parse(Console.ReadLine());

            if (number / 2 == 0)
            {
                Console.WriteLine("odd");
            }
            else
            {
                Console.WriteLine("even");
            }

            int.Parse(Console.ReadLine());
        }
    }
}
// Write a program that reads a number from the standard input,
// Then prints "Odd" if the number is odd, or "Even" if it is even.