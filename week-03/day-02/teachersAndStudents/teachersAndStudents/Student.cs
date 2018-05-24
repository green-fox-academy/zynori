using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teachersAndStudents
{
    class Student
    {
        private string StudentName;

        public Student(string studentName)
        {
            this.StudentName = studentName;
        }

        public static void Learn()
        {
            Console.WriteLine($"im learning");
        }

        public void Question(Teacher teachername)
        {
            Teacher.Answer();
        }
    }
}
