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
            Console.Write("Gimme a number: ");
            int number = int.Parse(Console.ReadLine());
            int otherNumbers = 0;

            for (int i = 0; i != otherNumbers; i++)
            {
                Console.Write("Gimme more: ");
                otherNumbers = int.Parse(Console.ReadLine());

                int finalnumber = otherNumbers + number;
            }

           

            int avgnumber = finalnumber / otherNumbers;

            Console.WriteLine("final: " + finalnumber + ", " + "avg: " + avgnumber);

            Console.ReadKey();


            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4
        }
    }
}
