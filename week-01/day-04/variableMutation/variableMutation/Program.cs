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
            e = e^3;

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
            if (g2 * 2 > g1)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }

            
            double h = 1357988018575474;

            if (h % 11 == 0)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }


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
            

            int j = 1521;

            if (j % 3 == 0 || j % 5 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            
            string k = "Apple";
            string l = "";
      
            for (int i = 0; i < 4; i++)
            {
                l = l + k;
            }
            k = l;
            Console.WriteLine(k);
           
            Console.ReadLine();
        }
    }
}
