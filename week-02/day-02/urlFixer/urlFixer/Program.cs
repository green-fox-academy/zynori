using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urlFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            url = url.Replace("bots", "odds");

            int index = url.IndexOf("https");
            string indexUrl = url.Insert(index + "https".Length, ":");
            url = indexUrl;

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            Console.WriteLine(url);
            Console.ReadLine();
        }
    }
}
