using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace copyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText(@"C:\Users\Anna\Desktop\greenfox\zynori\week-02\day-03\copyFile\copyFile\text.txt");
            File.AppendAllText(@"C:\Users\Anna\Desktop\greenfox\zynori\week-02\day-03\copyFile\copyFile\text2.txt", content);

            using (StreamReader sr = new StreamReader(@"C:\Users\Anna\Desktop\greenfox\zynori\week-02\day-03\copyFile\copyFile\text.txt"))
            {
                using (StreamReader sr2 = new StreamReader(@"C:\Users\Anna\Desktop\greenfox\zynori\week-02\day-03\copyFile\copyFile\text2.txt"))
                {
                    if (sr.ReadLine() == sr2.ReadLine())
                    {
                        Console.WriteLine(true);
                    } 
                    else
	                {
                        Console.WriteLine(false);
                    }
                }
            }
            
            Console.ReadLine();   
        }
    }
}
// Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
// It should take the filenames as parameters
// It should return a boolean that shows if the copy was successful