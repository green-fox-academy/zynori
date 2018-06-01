using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Person
    {
        private string name;
        private int age;
        private string gender;

        public string Name {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
        }

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        
        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }
        
        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {this.name}, a {this.age} year old {this.gender}.");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine($"My goal is: Live for the moment!");
        }
    }
}
