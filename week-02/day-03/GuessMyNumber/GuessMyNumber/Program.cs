using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myNumber = rnd.Next(1, 101);

            Console.WriteLine("I've the number between 1-100. You have 5 lives.");
            
            int lives = 5;

            while (lives > 0)
            {
                int yourNumber = Int32.Parse(Console.ReadLine());

                if (yourNumber == myNumber)
                {
                    Console.WriteLine("Congratulations.You won!");
                }
                else if (yourNumber < myNumber)
                {
                    lives--;
                    Console.WriteLine($"Too low. You have {lives} lives left.");
                }
                else if (yourNumber > myNumber)
                {
                    lives--;
                    Console.WriteLine($"Too high. You have {lives} lives left.");
                }
            }

            if (lives == 0)
            {
                Console.WriteLine($"Game over! My number was: {myNumber}");
            }

            Console.ReadLine();
        }
    }
}
//Write a program where the program chooses a number between 1 and 100. The player is then asked to enter a guess.If the player guesses wrong, 
//then the program gives feedback and ask to enter an other guess until the guess is correct.
//Make the range customizable (ask for it before starting the guessing).
//You can add lives. (optional)
//Example
//I've the number between 1-100. You have 5 lives.
//20
//Too high.You have 4 lives left.
//10
//Too low. You have 3 lives left.
//15
//Congratulations.You won!