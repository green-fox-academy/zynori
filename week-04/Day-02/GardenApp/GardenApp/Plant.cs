using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    public abstract class Plant
    {
        protected string color;
        protected double waterLevel = 0;
        protected double waterAbsorp;
        protected double minWaterAmount = 0;

        public Plant(string color)
        {
            this.color = color;
        }
     
        public string Color
        {
            get
            {
                return color;
            }
        }

        public double WaterLevel
        {
            get
            {
                return waterLevel;
            }
        }

        public void Watering(double waterAmount)
        {
            waterLevel += waterAbsorp * waterAmount;
        }

        public bool NeedWater()
        {
            return minWaterAmount > waterLevel;
        }
    }
}
