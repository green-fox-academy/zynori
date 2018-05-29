using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Garden
    {
        private List<Plant> plants;
        
        public Garden()
        {
            plants = new List<Plant>();
            plants.Add(new Tree("tree", "purple", 1, 4));
            plants.Add(new Tree("tree", "orange", 1, 4));
            plants.Add(new Flower("flower", "yellow", 2, 7));
            plants.Add(new Flower("flower", "blue", 4, 5));
        }
    }
}
