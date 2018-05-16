using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace logs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.

            List<String> log = Read();
            UniqueIP(log);
            GPratio(log);
            Console.ReadKey();
        }

        static List<String> Read() {
            StreamReader sr = new StreamReader("log.txt");
            List<String> rows = new List<String>();
            while (!sr.EndOfStream)
            {
                rows.Add(sr.ReadLine());
            }
            sr.Dispose();

            Console.WriteLine(rows.Count);

            return rows;
        }

        static List<String> UniqueIP(List<String> list) {
            List<String> uniqueIps = new List<String>();
            foreach (String row in list)
            {
                String ip = row.Substring(27, 11);
                if (!uniqueIps.Contains(ip)) {
                    uniqueIps.Add(ip);
                }
            }
            return uniqueIps;
        }

        static void GPratio(List<String> list) {
            int getCount = 0;
            int postCount = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains("GET"))
                {
                    //getCount = getCount + 1;
                    //getCount += 1;
                    getCount++;
                }
                else if (list[i].Contains("POST")) {
                    postCount++;
                }
            }

            Console.WriteLine(postCount+":"+getCount);

            double getPercent = (double)getCount / (double)(getCount + postCount) * 100;
            double postPercent = (double)postCount / (double)(getCount + postCount) * 100;

            Console.WriteLine(postPercent+"% "+getPercent+"%");
        }
    }
}
