using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teachersAndStudents
{
    class Teacher
    {
        private string TeacherName;

        public Teacher(string teacherName)
        {
            this.TeacherName = teacherName;
        }

        public void Teach(Student studentName)
        {
            Student.Learn();
        }

        public static void Answer()
        {
            Console.WriteLine($"im teaching");
        }
    }
}
