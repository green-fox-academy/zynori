using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 5, 6, 7 };
            
            foreach (var itemsOfNumbers in numbers)
            {
                Console.WriteLine(itemsOfNumbers);
            }

            Console.ReadLine();
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `numbers`
        }
    }
}
