using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var freq =
                from x in n
                group x by x into y
                select y;

            foreach (var item in freq)
            {
                Console.WriteLine(item.Key + " appears: " + item.Count() + " times");
            }
            
            Console.ReadLine();
        }
    }
}
//Write a LINQ Expression to find the frequency of numbers in the following array: