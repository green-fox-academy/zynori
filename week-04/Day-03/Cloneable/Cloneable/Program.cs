using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John", 20, "male", "BME");
            Object clone = john.Clone();
            Console.WriteLine(clone);
            Console.ReadLine();
        }
    }
}
