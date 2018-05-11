using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mileToConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("km:");
            int km = int.Parse(Console.ReadLine());
            double miles = km * 0.621371;

            Console.WriteLine(miles);
            int.Parse(Console.ReadLine());
        }
    }
}
