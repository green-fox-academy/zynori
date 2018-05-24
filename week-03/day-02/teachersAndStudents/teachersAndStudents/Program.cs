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
            var teacher1 = new Teacher("Bela");
            var teacher2 = new Teacher("Lilla");

            var student1 = new Student("Jeno");
            var student2 = new Student("Olga");

            teacher1.Teach(student1);
            teacher1.Teach(student2);

            student2.Question(teacher2);
            student2.Question(teacher1);

            Console.ReadKey();

        }
    }
}
