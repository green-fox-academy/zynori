using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Bird : Animal
    {
        public Bird(string name) : base(name){}

        public override string WantChild()
        {
            return "egg";
        }
    }
}
