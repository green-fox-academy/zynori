﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countFromTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("give me a number: ");
            int number01 = int.Parse(Console.ReadLine());

            Console.Write("give me another number: ");
            int number02 = int.Parse(Console.ReadLine());

            if (number01 > number02)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else if (number01 < number02)
            {
                for (int i = number01; i < number02; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
// Create a program that asks for two numbers
// If the second number is not bigger than the first one it should print:
// "The second number should be bigger"
// If it is bigger it should count from the first number to the second by one
// example:
// first number: 3, second number: 6, should print:
// 3
// 4
// 5