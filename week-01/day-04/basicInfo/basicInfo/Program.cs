using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Nora GIczy";
            int myAge = 28;
            double myHeight = 1.68;
            bool married = false;

            Console.WriteLine("name: " + myName);
            Console.WriteLine("age: " + myAge);
            Console.WriteLine("height: " + myHeight);

            if (married == true)
            {
                Console.WriteLine("married: married");
            }
            else
            {
                Console.WriteLine("married: not married");

            }

            Console.ReadLine();
        }
    }
}
