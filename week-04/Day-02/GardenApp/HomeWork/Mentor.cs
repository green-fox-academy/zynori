using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Mentor : Person
    {
        private string level;

        public Mentor (string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }
        
        public Mentor() : base()
        {
            level = "intermediate";
        }
    }
}
