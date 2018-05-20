using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            Greet(al);
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`
            Console.ReadLine();
        }

        static void Greet(string name)
        {
            Console.WriteLine("Greetings dear, {0}", name + "\n" + name);
        }
    }
}
