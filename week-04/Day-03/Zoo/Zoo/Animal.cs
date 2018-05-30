using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Animal
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }

        public Animal(string name)
        {
            this.Name = name;
        }

        public virtual string GetName()
        {
            return name;
        }

        public string Greet()
        {
            return $"{name}: Hi";
        }

        public virtual string WantChild()
        {
            return $"want a child from an";
        }
    }
}
