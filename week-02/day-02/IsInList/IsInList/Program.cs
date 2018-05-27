using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsInList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 14, 16 };

            Console.WriteLine(CheckNums(list));
            Console.ReadLine();
        }

        public static bool CheckNums(List<int> list)
        {
            bool contains = list.Contains(4) && list.Contains(8) && list.Contains(12) && list.Contains(16);
            return contains;
        }
    }
}
// Check if list contains all of the following elements: 4,8,12,16
// Create a method that accepts list as an input
// it should return "true" if it contains all, otherwise "false"