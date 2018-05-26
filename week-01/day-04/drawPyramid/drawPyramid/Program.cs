using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me one numeroooo: ");
            int pyramidNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= pyramidNum; i++)
            {
                for (int j = 1; j < pyramidNum - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
// Write a program that reads a number from the standard input, then draws a
// pyramid like this:
//    *
//   ***
//  *****
// *******
// The pyramid should have as many lines as the number was