using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.WriteLine(MakingMatches(boys, girls));
            Console.ReadLine();
        }

        public static StringBuilder MakingMatches(List<string>boys, List<string>girls)
        {
            StringBuilder merged = new StringBuilder();
            
            for (int i = 0; i < girls.Count; i++)
            {
                merged.Append(girls[i] + "\n");
                merged.Append(boys[i] + "\n");
            }

            return merged;
        }
    }
}
