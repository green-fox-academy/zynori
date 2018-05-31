using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    public class Tree : Plant
    {
        public Tree(string color) : base(color)
        {
            waterAbsorp = 0.4;
            minWaterAmount = 10;
        }
    }
}
