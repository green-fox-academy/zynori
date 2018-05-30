using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    public class Plant
    {
        private string type;
        private string color;
        private int waterLevel;
        private double waterAbsorp;
        private int waterAmount;

        public Plant(string type, string color, int waterLevel, double waterAbsorp)
        {
            this.type = type;
            this.color = color;
            this.waterLevel = waterLevel;
            this.waterAbsorp = waterAbsorp;
            waterAmount = 0;
            this.Show();
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
        }

        public int WaterLevel
        {
            get
            {
                return waterLevel;
            }
        }

        public double WaterAbsorp
        {
            get
            {
                return waterAbsorp;
            }
        }

        public void Show()
        {
            Console.WriteLine($"There is one {color} {type} in the garden.");
        }
    }
}
