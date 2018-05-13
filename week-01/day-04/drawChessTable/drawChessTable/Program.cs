using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if (i % 2 == 0 )
                    {
                        Console.Write("% ");
                    }
                    else
                    {
                        Console.Write(" %");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
