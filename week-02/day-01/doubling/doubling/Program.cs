using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum = 123;

            Console.WriteLine(Doubling(baseNum));
            Console.ReadLine();
        }

        public static int Doubling(int num)
        {
            return num * 2;
        }
        // - Create an integer variable named `baseNum` and assign the value `123` to it
        // - Create a function called `doubling` that doubles it's input parameter and returns with an integer
        // - Print the result of `doubling(baseNum)`
    }
}
