using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalVariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            // if a is even increment out by one
            int a = 24;
            int out1 = 0;

            if (a % 2 == 0)
            {
                out1 = a - 1;
            }

            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "Less!",
            // if more than 20 set out2 to "More!"
            int b = 13;
            string out2 = "";

            if (b >= 10 && b <= 20)
            {
                out2 = "Sweet!";
            }
            else if( b < 10 )
            {
                out2 = "Less!";
            }
            else
            {
                out2 = "More!";
            }
            
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same
            int c = 123;
            int credits = 100;
            bool isBonus = false;

            if (credits >= 50)
            {
                isBonus = false;
                c -= 2;
            }
            else if (credits < 50)
            {
                isBonus = false;
                c -- ;
            }
            else if (isBonus == true)
            {
            }

            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"
            int d = 3;
            int time = 120;
            string out3 = "";

            if ( d % 4 == 0 && time <= 200)
            {
                out3 = "Check";
            }
            else if (d % 4 == 0 && time > 200)
            {
                out3 = "Time out";
            }
            else
            {
                out3 = "Run Forest Run!";
            }

            Console.WriteLine(out1);
            Console.WriteLine(out2);
            Console.WriteLine(c);
            Console.WriteLine(out3);
            Console.ReadLine();
        }
    }
}
