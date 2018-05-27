using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace countLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = File.Create("test.txt"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is a new file...");
                fs.Write(info, 0, info.Length);
            }

            try
            {
                if (File.Exists("test.txt"))
                {
                    Console.WriteLine(File.ReadAllLines("test.txt").Length);
                    Console.ReadLine();
                }
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine(0); ;
            }

            Console.ReadLine();
        }
    }
}
// Write a function that takes a filename as string,
// then returns the number of lines the file contains.
// It should return zero if it can't open the file, and
// should not raise any error.