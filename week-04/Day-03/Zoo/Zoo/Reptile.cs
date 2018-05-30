using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Reptile : Animal
    {
        public Reptile(string name) : base(name){}

        public override string WantChild()
        {
            return "egg";
        }
    }
}
