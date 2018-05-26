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
            string myName = "Nora Giczy";
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
// Define several things as a variable then print their values
// Your name as a string
// Your age as an integer
// Your height in meters as a double
// Whether you are married or not as a boolean
