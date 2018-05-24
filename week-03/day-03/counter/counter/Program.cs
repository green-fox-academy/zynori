using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 60;
            Console.WriteLine(Recursion(n));
            Console.ReadKey();
        }

        public static int Recursion(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine(n);
                return Recursion(n - 1);
            }
        }
    }
}
// Write a recursive function that takes one parameter: n and counts down from n.
