using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace writeMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"test.txt";
            MultipleLines(path, "bela", 6);
            
            Console.ReadLine();
            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.
        }

        static void MultipleLines(string path, string word, int number)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < number; i++)
                {
                    sw.WriteLine(word);
                }

                sw.Dispose();
            }
            catch (Exception)
            {

                Console.WriteLine("Not working"); ;
            }
        }
    }
}
