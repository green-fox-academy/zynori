using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Student : Person
    {
        private string previousOrganization;
        private double skippedDays = 0;
        private int numberOfDays;
        

        public Student(string name, int age, string gender, string previousOrganization, double skippedDays) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = skippedDays;
        }
        
        public void GetGoal()
        { 
            Console.WriteLine("Be a junior software developer.");
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} from {this.previousOrganization} who skipped {this.skippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays++;
        }
    }
}
