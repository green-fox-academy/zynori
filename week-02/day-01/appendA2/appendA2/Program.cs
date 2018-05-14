using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appendA2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "kuty", "macsk", "cic" };

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i] + "a");
            }

            Console.ReadLine();
            // - Create an array variable named `animals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end
        }
    }
}
