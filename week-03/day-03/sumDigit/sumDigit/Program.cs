﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Recursion(50));
            Console.ReadLine();
        }

        public static int Recursion(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n % 10 + Recursion(n / 10);
            }
        }
    }
}
// Given a non-negative int n, return the sum of its digits recursively (no loops). 
// Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
// divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
