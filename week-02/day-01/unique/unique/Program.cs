using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace unique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Unique(new int[] { 1, 11, 34, 11, 52, 61, 1, 34 });
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.ReadLine();
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once

            //  Example
            // Console.WriteLine(Unique({ 1, 11, 34, 11, 52, 61, 1, 34}));
            //  should print: `[1, 11, 34, 52, 61]`
        }

        public static List<int> Unique(int[] array)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!list.Contains(array[i]))
                {
                    list.Add(array[i]);
                }
            }
            return list;
        }
    }
}
