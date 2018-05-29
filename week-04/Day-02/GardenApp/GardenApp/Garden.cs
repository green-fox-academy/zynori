using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Garden
    {
        private List<Plant> garden;

        public Garden()
        {
            garden = new List<Plant>();
            {
                new Flower("flower", "yellow"),
                new Flower("flower", "blue"),
                new Tree("tree", "purple"),
                new Tree("tree", "orange")
            };
        }
    }
}
