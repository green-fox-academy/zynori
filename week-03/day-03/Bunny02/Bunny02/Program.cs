using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Recursion(3));
            Console.ReadLine();
        }

        public static int Recursion(int bunny)
        {
            if (bunny == 1)
            {
                return 2;
            }
            else if (bunny % 2 != 0)
            {
                return 2 + Recursion(bunny - 1);
            }
            else
            {
                return 3 + Recursion(bunny - 1); 
            }
        }
    }
}
// We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
// (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
// have 3 ears, because they each have a raised foot. Recursively return the
// number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
