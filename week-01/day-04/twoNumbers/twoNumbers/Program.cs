using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 22;
            int number2 = 13;
            double doubleNumber1 = 22;
            double doubleNumber2 = 13;

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / number2);
            Console.WriteLine(doubleNumber1 / doubleNumber2);
            Console.WriteLine(doubleNumber1 % doubleNumber2);
            Console.ReadLine();
        }
    }
}
// Create a program that prints a few operations on two numbers: 22 and 13
// Print the result of 13 added to 22
// Print the result of 13 substracted from 22
// Print the result of 22 multiplied by 13
// Print the result of 22 divided by 13 (as a decimal fraction)
// Print the integer part of 22 divided by 13
// Print the reminder of 22 divided by 13