﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(" 1 ");
                    }
                    else
                    {
                        Console.Write(" 0 ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
        }
    }
}
