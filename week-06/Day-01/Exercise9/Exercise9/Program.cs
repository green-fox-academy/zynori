using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[5];
            chars[0] = 'H';
            chars[1] = 'e';
            chars[2] = 'l';
            chars[3] = 'l';
            chars[4] = 'o';

            string charToString = String.Join("", chars.Select(s => s.ToString()));

            Console.WriteLine(charToString);
            Console.ReadLine();
        }
    }
}
