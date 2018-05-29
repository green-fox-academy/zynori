using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    public class Tree : Plant
    {
        public Tree(string type, string color, int needForWater, double waterAbsorp) : base(type, color, needForWater, waterAbsorp)
        { }
    }
}
