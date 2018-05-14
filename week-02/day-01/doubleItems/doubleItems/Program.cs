using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = { 3, 4, 5, 6, 7 };

            for (int i = 0; i < numList.GetLength(0); i++)
            {
                Console.WriteLine(numList[i] * 2);
            }            
            
            Console.ReadLine();
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
        }
    }
}
