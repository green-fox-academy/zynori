using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = b;
            b = a;
            a = c;

            Console.WriteLine(a);
            Console.WriteLine(b);



            Console.ReadLine();
        }
    }
}
