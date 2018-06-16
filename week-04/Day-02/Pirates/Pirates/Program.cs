using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate pirate = new Pirate("Bela", 0);

            pirate.DrinkSomeRum();
            pirate.DrinkSomeRum();
            pirate.DrinkSomeRum();
            pirate.DrinkSomeRum();
            pirate.DrinkSomeRum();
            Console.WriteLine(pirate.HowsItGoingMate());


            Console.ReadLine();
        }
    }
}
