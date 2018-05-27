using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 7 };
            Console.WriteLine(ContainsSeven(list));
            Console.ReadLine();
        }

        public static string ContainsSeven(List<int> list)
        {
            foreach (var item in list)
            {
                if (list.Contains(7))
                {
                    return "Hoorray";
                }
                else
                {
                    return "Nooooo";
                }
            }
            return list.ToString();
        }
    }
}
// Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
// The output should be: "Noooooo"
// Do this again with a different solution using different list methods!