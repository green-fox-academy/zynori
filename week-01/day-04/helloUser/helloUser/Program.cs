using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;

            Console.WriteLine("What's your name?");
            userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}!");
            Console.ReadLine();
        }
    }
}
// Modify this program to greet user instead of the World!
// The program should ask for the name of the user