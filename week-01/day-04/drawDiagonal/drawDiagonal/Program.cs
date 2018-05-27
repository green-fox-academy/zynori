using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawDiagonal
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
                for (int j = 0; j < number; j++)
                {
                    if (i == j || i == 0 || j == 0 || i == number -1 || j == number -1)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
// Write a program that reads a number from the standard input, then draws a
// square like this:
// %%%%%
// %%  %
// % % %
// %  %%
// %%%%%
// The square should have as many lines as the number was
