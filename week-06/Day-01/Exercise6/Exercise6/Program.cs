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

            var freq =
                from a in inputStuff
                group a by a into b
                select b;

            freq.ToList().ForEach(b => Console.WriteLine(b.Key + " appears: " + b.Count() + " times"));

            Console.ReadLine();
        }
    }
}
