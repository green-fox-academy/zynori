using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teachersAndStudents
{
    class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }

        public void Learn()
        {
            Console.WriteLine($"{this.GetName()}: I'm learning");
        }

        public void Question(Teacher teacher)
        {
            teacher.Answer();
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
