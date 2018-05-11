using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("give me a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i + " * " + number + " = " + i * number);
            }

            Console.ReadLine();
        }
    }
}
