using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 12;
            double surfaceArea = 6 * (a * a);
            double volume = a * a * a;

            Console.Write("Surface Area: " + surfaceArea + "\n" + "Volume: " + volume);
            Console.ReadLine();
        }
    }
}
// Write a program that stores 3 sides of a cuboid as variables (doubles)
// The program should write the surface area and volume of the cuboid like:
//
// Surface Area: 600
// Volume: 1000