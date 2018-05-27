using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace printEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"my-file.txt";

            try
            {
                if (!File.Exists(path))
                {
                    using (FileStream fs = new FileStream(path, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            Console.WriteLine(sr.ReadLine());
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt"); ;
            }

            Console.ReadLine();   
        }
    }
}
// Write a program that opens a file called "my-file.txt", then prints
// each of lines form the file.
// If the program is unable to read the file (for example it does not exists),
// then it should print an error message like: "Unable to read file: my-file.txt"