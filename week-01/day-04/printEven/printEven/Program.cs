﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printEven
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 500; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i++);
                }
            }

            Console.ReadLine();
        }
    }
}
