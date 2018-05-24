using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teachersAndStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacherName = new Teacher("Bela");
            var teacherName1 = new Teacher("Lilla");

            var studentName = new Student("Jeno");
            var studentName1 = new Student("Olga");
            var studentName2 = new Student("Klara");

            Console.WriteLine($"The {studentName1.Question(teacherName1)} ask a question and {teacherName} is answering");
            Console.ReadKey();

        }
    }
}
