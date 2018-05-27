using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(number));
            Console.ReadLine();
        }

        public static int Sum(int number)
        {
            int sumOfNumber = 0;

            for (int i = 1; i <= number; i++)
            {
               sumOfNumber += i;
            }

            return sumOfNumber;
        }
        // - Write a function called `sum` that sum all the numbers
        //   until the given parameter and returns with an integer
    }
}
