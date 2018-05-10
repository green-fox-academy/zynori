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

            int a = 3;
            a += 10;

            Console.WriteLine(a);


            int b = 100;
            b -= 7;

            Console.WriteLine(b);


            int c = 44;
            c *= 2;

            Console.WriteLine(c);


            int d = 125;
            d /= 5;

            Console.WriteLine(d);


            int e = 8;
            e = (e * e) * e;

            Console.WriteLine(e);


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
            

            int g1 = 350;
            int g2 = 200;
            int g3 = g2 * 2;



            // tell if the double of g2 is bigger than g1 (print as a boolean)

            double h = 1357988018575474;
            // tell if it has 11 as a divisor (print as a boolean)

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            int j = 1521;
            // tell if j is dividable by 3 or 5 (print as a boolean)

            string k = "Apple";
            //fill the k variable with its cotnent 4 times

            Console.WriteLine(k);

            Console.ReadLine();
        }
    }
}
