using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Give me another one: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (b > a)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("They are equals");
            }
            Console.ReadLine();
        }
    }
}
// Write a program that asks for two numbers and prints the bigger one.