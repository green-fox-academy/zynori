using System;
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

            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.

            Console.WriteLine(PutSaturn(planetList));
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"
            Console.ReadLine();
        }

        public static string PutSaturn(List<string> inputPlanet)
        {
            StringBuilder planetBuilder = new StringBuilder();

            foreach (string currentPlanet in inputPlanet)
            {
                planetBuilder
                .Append(currentPlanet)
                .Append(", ");
            }

            return planetBuilder.ToString();
        }
    }
}
