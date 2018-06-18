using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            IEnumerable<int> squaredVal =
                from nums in n
                where nums * nums > 20
                select nums;

            squaredVal.ToList().ForEach(nums => Console.WriteLine(nums));

            Console.ReadLine();
        }
    }
}
