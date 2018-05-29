using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    public class Flower : Plant
    {
        public Flower(string type, string color, int needForWater, double waterAbsorp) : base(type, color, needForWater, waterAbsorp)
        { }
    }
}
