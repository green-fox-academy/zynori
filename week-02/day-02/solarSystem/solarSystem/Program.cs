﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            planetList.Insert(4, "Saturn");

            Console.WriteLine(PutSaturn(planetList));
            Console.ReadLine();
        }

        public static string PutSaturn(List<string> inputPlanet)
        {
            StringBuilder planetBuilder = new StringBuilder();

            foreach (string currentPlanet in inputPlanet)
            {
                planetBuilder.Append(currentPlanet);

                if (inputPlanet.IndexOf(currentPlanet) != inputPlanet.Count - 1)
                {
                    planetBuilder.Append(", ");
                }
            }

            return planetBuilder.ToString();
        }
    }
}
// Saturn is missing from the planetList
// Insert it into the correct position
// Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.
// Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"