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
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once

            //  Example
            // Console.WriteLine(Unique({ 1, 11, 34, 11, 52, 61, 1, 34}));
            //  should print: `[1, 11, 34, 52, 61]`
            List<int> inputList = new List<int> { 1, 11, 34, 11, 52, 61, 1, 34 };
            int[] resultList = Unique(inputList).ToArray();
            for (int i = 0; i < resultList.Length; i++)
            {
                Console.WriteLine(resultList[i]);
            }

            Console.ReadLine();
        }

        static List<int> Unique(List<int> inputList)
        {
            List<int> resultList = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (!resultList.Contains(inputList[i]))
                {
                    resultList.Add(inputList[i]);
                }
            }
            return resultList;
        }
    }
}
