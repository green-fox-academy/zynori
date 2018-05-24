using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teachersAndStudents
{
    class Teacher
    {
        private string name;

        public Teacher(string name)
        {
            this.name = name;
        }

        public void Teach(Student student)
        {
            student.Learn();
        }

        public void Answer()
        {
            Console.WriteLine($"{this.GetName()}: I'm teaching");
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
