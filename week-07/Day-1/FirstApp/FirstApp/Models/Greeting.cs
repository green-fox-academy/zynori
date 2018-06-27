using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public static long IdCount { get; set; }
        public string Content { get; set; }

        public Greeting(string name)
        {
            Content = name;
            Id = IdCount++;
        }

        public Greeting()
        {
            Id = IdCount++;
        }
    }
}
