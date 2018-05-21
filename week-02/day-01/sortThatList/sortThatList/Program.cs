using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortThatList
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as parameter
            //  Returns a list where the elements are sorted in ascending numerical order
            //  Make a second boolean parameter, if it's `True` sort that list descending
            //  Example:
            //  should print [5, 9, 12, 24, 34]
            //  should print [34, 24, 12, 9, 5]
            int[] sortedBubble = Bubble(new int[] { 34, 12, 24, 9, 5 });
            for (int i = 0; i < sortedBubble.Length; i++)
            {
                Console.WriteLine(sortedBubble[i]);
            }

            int[] advancedSortedBubble = AdvancedBubble(new int[] { 34, 12, 24, 9, 5 }, true);
            for (int i = 0; i < advancedSortedBubble.Length; i++)
            {
                Console.WriteLine(advancedSortedBubble[i]);
            }

            Console.ReadLine();
        }

        static int[] Bubble(int[] inputArray)
        {
            List<int> sortedBubble = inputArray.ToList();
            sortedBubble.Sort();
            return sortedBubble.ToArray();
        }

        static int[] AdvancedBubble(int[] inputArray, bool sortType)
        {
            List<int> sortedBubble = inputArray.ToList();
            sortedBubble.Sort();

            if (sortType == true)
            {
                sortedBubble.Reverse();
            }

            return sortedBubble.ToArray();
        }
    }
}
