using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            IEnumerable<string> sortedCities =
                from a in cities
                where a.StartsWith("A") && a.EndsWith("I")
                select a;

            sortedCities.ToList().ForEach(a => Console.WriteLine(a));

            Console.ReadLine();
        }
    }
}
// Write a LINQ Expression to find the strings which starts with A and ends with I in the following array: