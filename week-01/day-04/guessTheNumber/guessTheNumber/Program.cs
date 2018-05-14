using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess the number: ");
            int guess = int.Parse(Console.ReadLine());
            int number = 12;

            while (guess != number)
            {
                if (guess > number)
                {
                    Console.WriteLine("The stored number is lower");

                }
                else
                {
                    Console.WriteLine("The stored number is higher");
                }

                Console.WriteLine("Give me another number: ");
                guess = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You found the number: " + number);
            Console.ReadKey();
        }
    }
}
