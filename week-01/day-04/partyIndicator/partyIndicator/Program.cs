using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("girls: ");
            int girls = int.Parse(Console.ReadLine());
            Console.Write("boys: ");
            int boys = int.Parse(Console.ReadLine());

            if (girls == boys && girls + boys > 20)
            {
                Console.WriteLine("The party is excellent!");
            }
            else if (girls != boys && girls + boys > 20)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (girls + boys < 20)
            {
                Console.WriteLine("Average party...");
            }
            else
            {
                Console.WriteLine("Sausage party");
            }

            Console.ReadLine();
        }
    }
}
