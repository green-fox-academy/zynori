using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = { "first", "second", "third" };

            for (int i = 0; i < abc.Length; i++)
            {
                abc[0] = "abc";
                abc[2] = "abc";
                Console.WriteLine(abc[i]);
            }
            Console.ReadLine();
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
        }
    }
}
