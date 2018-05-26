using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi, tell me how many chicken do you have? ");
            int chickens = int.Parse(Console.ReadLine());
            Console.Write("Hi, tell me how many pig do you have? ");
            int pigs = int.Parse(Console.ReadLine());

            int animalsLegs = chickens * 2 + pigs * 4;

            Console.WriteLine(animalsLegs);
            Console.ReadLine();
        }
    }
}
// Write a program that asks for two integers
// The first represents the number of chickens the farmer has
// The second represents the number of pigs owned by the farmer
// It should print how many legs all the animals have