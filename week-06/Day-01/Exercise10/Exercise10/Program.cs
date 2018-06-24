using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxes = new List<Fox>()
            {
            new Fox() {Name = "Bela", Type = "arctic", Color = "white" },
            new Fox() {Name = "Jeno", Type = "pallida", Color = "green" },
            new Fox() {Name = "Klari", Type = "corsac", Color = "yellow" },
            new Fox() {Name = "Sandor", Type = "pallida", Color = "green" },
            new Fox() {Name = "Pista", Type = "ocelot", Color = "green" }
            };

            IEnumerable<Fox> listOfgreenFoxes = from fox in foxes
                                     where fox.Color.Equals("green")
                                     select fox;

            foreach (Fox gfox in listOfgreenFoxes)
            {
                Console.WriteLine("This is green fox: " + gfox.Name);
            }

            IEnumerable<Fox> listOfGreenPallida = from fox in foxes
                                                  where fox.Color.Equals("green") && fox.Type.Equals("pallida")
                                                  select fox;

            foreach (Fox gpFox in listOfGreenPallida)
            {
                Console.WriteLine("This is green fox and pallida: " + gpFox.Name);
            }

            IEnumerable<Fox> findGreenFox = foxes.Where(f => f.Color.Equals("green"));
            findGreenFox.ToList().ForEach(f => Console.WriteLine("This is green fox: " + f.Name));

            Console.ReadLine();
        }
    }
}
//Create a Fox class with 3 properties(name, type, color) Fill a list with at least 5 foxes, 
//it's up to you how you name/create them! Write a LINQ Expression to find the foxes with green color! 
//Write a LINQ Expression to find the foxes with green color and pallida type!