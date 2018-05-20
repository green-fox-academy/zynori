using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aj = new int[] { 3, 4, 5, 6, 7 };
            int[] temp = new int[aj.Length];
            for (int i = 0; i < aj.Length; i++)
            {
                temp[i] = aj[aj.Length - i - 1];
                Console.WriteLine(temp[i]);
            }
            Console.ReadLine();
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
        }
    }
}
