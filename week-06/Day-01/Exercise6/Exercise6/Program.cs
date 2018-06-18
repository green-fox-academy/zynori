using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something pls");
            string inputStuff = Console.ReadLine();

            Dictionary<char, int> freq =
                (from a in inputStuff
                group a by a into b
                select b).ToDictionary(b => b.Key, b => b.ToList().Count);

            freq.ToList().ForEach(b => Console.WriteLine(b));
            
            Console.ReadLine();
        }
    }
}
