﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i + " * " + number + " = " + i * number);
            }

            Console.ReadLine();
        }
    }
}
// Create a program that asks for a number and prints the multiplication table with that number
// Example:
// The number 15 should print:
// 1 * 15 = 15
// 2 * 15 = 30
// 3 * 15 = 45
// 4 * 15 = 60
// 5 * 15 = 75
// 6 * 15 = 90
// 7 * 15 = 105
// 8 * 15 = 120
// 9 * 15 = 135
// 10 * 15 = 150