using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string greetings = "Hello World!";
            byte howOldAreYou = 42;
            double exactWidthLittleFingerOnRightHand = 3.1415;

            Console.WriteLine(greetings);
            Console.WriteLine(howOldAreYou);
            Console.Write(exactWidthLittleFingerOnRightHand);
            Console.Read();
        }
    }
}
