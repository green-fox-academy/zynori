using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant>();
            plants.Add(new Tree("purple"));
            plants.Add(new Tree("orange"));
            plants.Add(new Flower("yellow"));
            plants.Add(new Flower("blue"));
            Garden NoriGarden = new Garden(plants);

            PrintStatus(NoriGarden.GetStatus());
            Console.WriteLine("Watering 40");
            NoriGarden.Watering(40);
            PrintStatus(NoriGarden.GetStatus());
            Console.WriteLine("Watering 70");
            NoriGarden.Watering(70);
            PrintStatus(NoriGarden.GetStatus());

            Console.ReadLine();
        }

        public static void PrintStatus(List<string> status)
        {
            foreach (string statusLine in status)
            {
                Console.WriteLine(statusLine);
            }
        }
    }
}
