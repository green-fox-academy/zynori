using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ai = { 3, 4, 5, 6, 7 };
            int sum = 0;

            for (int i = 0; i < ai.Length; i++)
            {
                sum += ai[i];
            }

            Console.WriteLine(sum);
            Console.ReadLine();

            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`
        }
    }
}
