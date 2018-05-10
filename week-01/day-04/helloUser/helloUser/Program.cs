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

            Console.WriteLine("Hello {0}", userName + "!");
            Console.ReadLine();
        }
    }
}
