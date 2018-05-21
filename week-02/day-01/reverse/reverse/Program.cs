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
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
            int[] aj = { 3, 4, 5, 6, 7 };
            aj = Reversed(aj);

            for (int i = 0; i < aj.Length; i++)
            {
                Console.WriteLine(aj[i]);
            }

            Console.ReadLine();
        }

        static int[] Reversed(int[] inputElements)
        {
            int[] result = new int [inputElements.Length];
            
            for (int i = 0; i < inputElements.Length; i++)
            {
                result[i] = inputElements[inputElements.Length-i-1];
            }

            return result;
        }
    }
}
