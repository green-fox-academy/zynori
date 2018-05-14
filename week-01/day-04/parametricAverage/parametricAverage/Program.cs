using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametricAverage
{
    class Program
    {
        static void Main(string[] args)
        {

            int mainNumber;
            int number = 0;
            int sum = 0;
            double avg;

            Console.Write("Gimme a number: ");
            mainNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < mainNumber; i++)
            {
                Console.Write("Gimme some more: ");
                number = int.Parse(Console.ReadLine());
                sum += number;
            }

            avg = (double)sum / number;
            Console.WriteLine("Sum: " + sum + ", " + "Average: " + avg);
            Console.ReadLine();

            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4
        }
    }
}
