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
        private int needForWater;
        private double waterAbsorp;

        public Plant(string type, string color, int needForWater, double waterAbsorp)
        {
            this.type = type;
            this.color = color;
            this.needForWater = needForWater;
            this.waterAbsorp = waterAbsorp;
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

        public int NeedForWater
        {
            get
            {
                return needForWater;
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
            Console.WriteLine(color + " " + type);
        }
    }
}
