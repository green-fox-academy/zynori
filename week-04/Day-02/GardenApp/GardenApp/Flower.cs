using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    public class Flower : Plant
    {
        public Flower(string color) : base(color)
        {
            waterAbsorp = 0.75;
            minWaterAmount = 5;
        }
    }
}
