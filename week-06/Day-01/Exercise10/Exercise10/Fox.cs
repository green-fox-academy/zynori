using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Fox
    {
        private string name;
        private string type;
        private string color;
        /*
        public Fox(string name, string type, string color)
        {
            this.name = name;
            this.type = type;
            this.color = color;
        }
        */
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Color { get => color; set => color = value; }
    }
}
