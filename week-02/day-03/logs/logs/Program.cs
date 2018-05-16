using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Anna\Desktop\greenfox\zynori\week - 02\day - 03\logs\logs\log.txt";

            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.
        }

        static string ReadAllLines(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
