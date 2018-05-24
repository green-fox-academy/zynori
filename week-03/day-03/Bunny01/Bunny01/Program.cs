using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny01
{
    class Program
    {
        static void Main(string[] args)
        {
            int bunny = int.Parse(Console.ReadLine());
            Console.WriteLine(Recursion(bunny));
            Console.ReadLine();
        }

        public static int Recursion(int bunny)
        {
            if (bunny == 0)
            {
                return bunny;
            }
            else
            {
                return Recursion(bunny - 1) + 2;
            }
        }
    }
}
// We have a number of bunnies and each bunny has two big floppy ears.
// We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).