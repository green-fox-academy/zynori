﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number: ");

            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
            Console.ReadLine();

        }
    }
}
// Write a program that reads a number from the standard input, then draws a
// triangle like this:
// *
// **
// ***
// ****
// The triangle should have as many lines as the number was