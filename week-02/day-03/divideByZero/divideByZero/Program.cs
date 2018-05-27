using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace divideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            int givenNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine(DoTheMath(givenNumber));
            Console.ReadLine();
            
        }

        static string DoTheMath(int givenNumber)
        {
            int baseNumber = 10;

            try
            {
                givenNumber = baseNumber / givenNumber;
                return givenNumber.ToString();
            }
            catch (DivideByZeroException)
            {
                return "fail";                
            }
        }
    }
}
// Create a function that takes a number
// divides ten with it,
// and prints the result.
// It should print "fail" if the parameter is 0