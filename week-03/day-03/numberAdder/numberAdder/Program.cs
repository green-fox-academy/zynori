using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Console.WriteLine(Recursion(n));
            Console.ReadLine();
        }

        public static int Recursion(int n)
        {
            if (n == 100)
            {
                return 100;
            }
            else
            {
                Console.WriteLine(n);
                return Recursion(n+1);
            }
        }
    }
}
// Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
