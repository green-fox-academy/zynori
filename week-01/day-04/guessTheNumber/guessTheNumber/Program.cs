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
// Write a program that stores a number, and the user has to figure it out.
// The user can input guesses, after each guess the program would tell one
// of the following:
// The stored number is higher
// The stried number is lower
// You found the number: 8