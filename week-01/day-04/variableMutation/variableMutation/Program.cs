using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            // make it bigger by 10
            int a = 3;
            a += 10;

            // make it smaller by 7
            int b = 100;
            b -= 7;

            // please double c's value
            int c = 44;
            c *= 2;

            // please divide by 5 d's value
            int d = 125;
            d /= 5;

            // please cube of e's value
            int e = 8;
            e = e^3;

            // tell if f1 is bigger than f2 (print as a boolean)
            int f1 = 123;
            int f2 = 345;
            if (f1 < f2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // tell if the double of g2 is bigger than g1 (print as a boolean)
            int g1 = 350;
            int g2 = 200;
            if (g2 * 2 > g1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // tell if it has 11 as a divisor (print as a boolean)
            double h = 1357988018575474;

            if (h % 11 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            int i1 = 10;
            int i2 = 3;
            if (i1 > (i2 ^ 2) && i1 < (i2 ^ 3))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            // tell if j is dividable by 3 or 5 (print as a boolean)
            int j = 1521;

            if (j % 3 == 0 || j % 5 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //fill the k variable with its cotnent 4 times
            string k = "Apple";
            string l = "";
      
            for (int i = 0; i < 4; i++)
            {
                l = l + k;
            }

            k = l;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
