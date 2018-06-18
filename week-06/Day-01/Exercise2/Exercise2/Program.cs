﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            
            double avgOddNums =
                (from num in n
                where num % 2 == 1
                select num).Average();

            Console.WriteLine(avgOddNums);
            Console.ReadLine();
        }
    }
}
