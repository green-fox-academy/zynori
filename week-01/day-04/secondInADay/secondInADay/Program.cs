﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;
            int seconds = currentSeconds + currentMinutes * 60 + currentHours * 60 * 60;
            int secondsInADay = 24 * 60 * 60;
            int remainingSec = secondsInADay - seconds;

            Console.WriteLine(remainingSec);
            Console.ReadLine();
        }
    }
}
// Write a program that prints the remaining seconds (as an integer) from a
// day if the current time is represented by the variables