using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("give me a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Not enough");
            }
            else if (number == 1)
            {
                Console.WriteLine("One");
            }
            else if (number == 2)
            {
                Console.WriteLine("Two");
            }
            else if (number > 2)
            {
                Console.WriteLine("A lot");
            }

            Console.ReadLine();
        }
    }
}
