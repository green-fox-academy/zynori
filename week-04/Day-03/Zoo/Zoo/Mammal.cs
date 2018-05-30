using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Mammal : Animal
    {
        public Mammal(string name) : base(name) {}

        public override string WantChild()
        {
            return "uterus";
        }
    }
}
