using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Plant : Garden
    {
        private string type;
        private string color;

        public Plant(string type, string color)
        {
            this.type = type;
            this.color = color;
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

        public void Show()
        {
            Console.WriteLine(color, type);
        }
    }
}
