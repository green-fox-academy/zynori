using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appendLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };

            Console.WriteLine(AppendA(far));
            Console.ReadLine();
        }

        public static StringBuilder AppendA(List<string> far)
        {
            StringBuilder merged = new StringBuilder();

            for (int i = 0; i < far.Count; i++)
            {
                merged.Append("\"" + far[i] + "a\", ");
            }

            return merged;   
        }
    }
}
// Create a method called AppendA() that adds "a" to every string in the far list.
// The parameter should be a list.
// Expected output: "kutya", "macska", "kacsa", "róka", "halacska"