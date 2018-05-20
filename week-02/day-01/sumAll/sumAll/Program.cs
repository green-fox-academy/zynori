using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ai = new int[5] { 3, 4, 5, 6, 7 };
            Console.WriteLine(Summing(ai));
            Console.ReadLine();
        }

        public static int Summing(int[] summ)
        {
            int sum = 0;
            for (int i = 0; i < summ.Length; i++)
            {
                sum += summ[i];
            }
            return sum;
        }
    }
}
