using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Helloka bela Ez nagy betu";

            var upperA =
                from chars in a
                where chars.Equals(Char.ToUpper(chars))
                select chars;

            upperA.ToList().ForEach(chars => Console.Write(chars));

            Console.ReadLine();
        }
    }
}
// Write a LINQ Expression to find the uppercase characters in a string!