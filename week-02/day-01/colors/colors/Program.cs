﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] colors = new string[3][];
            {
                colors[0] = new string[] { "lime", "forest green", "olive", "pale green", "spring" };
                colors[1] = new string[] { "orange red", "red", "tomato" };
                colors[2] = new string[] { "orchid", "violet", "pink", "hot pink" };
            };

            // - Create a two dimensional array
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`
            Console.ReadLine();
        }
    }
}
