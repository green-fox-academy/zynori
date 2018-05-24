using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Recursion(baseNumber, n));
            Console.ReadLine();
        }

        public static int Recursion (int baseNumber, int n)
        {
            if (n == 1)
            {
                return baseNumber;
            }
            else
            {
                return baseNumber * Recursion(baseNumber, n - 1);
            }
        }
    }
}
// Given base and n that are both 1 or more, compute recursively (no loops)
// the value of base to the n power, so powerN(3, 2) is 9 (3 squared).