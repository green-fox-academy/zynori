using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(number));
            Console.ReadLine();
        }
        
        public static int Factorial(int number)
        {
            int factOfNumber = 1;
            for (int i = 1; i <= number; i++)
            {
                factOfNumber *= i;
            }

            return factOfNumber;
        }
    }
}
// - Create a function called `factorio`
//   that returns it's input's factorial