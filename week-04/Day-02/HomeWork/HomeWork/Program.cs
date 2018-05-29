using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var students = new List<Student>();
            var mentors = new List<Mentor>();
            var sponsors = new List<Sponsor>();

            var mark = new Person("Mark", 46, "male");
            people.Add(mark);
            var jane = new Person();
            people.Add(jane);
            var john = new Student("John Doe", 20, "male", "BME");
            students.Add(john);
            var student = new Student();
            students.Add(student);
            var gandhi = new Mentor("Gandhi", 148, "male", "senior");
            mentors.Add(gandhi);
            var mentor = new Mentor();
            mentors.Add(mentor);
            var sponsor = new Sponsor();
            sponsors.Add(sponsor);
            var elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
            sponsors.Add(elon);

            student.SkipDays(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }
            for (int i = 0; i < 3; i++)
            {
                sponsor.Hire();
            }

            foreach (var person in people)
            {
                person.Introduce();
                person.GetGoal();
            }
            
            foreach (var person in students)
            {
                person.Introduce();
                person.GetGoal();
            }

            foreach (var person in mentors)
            {
                person.Introduce();
                person.GetGoal();
            }

            foreach (var person in sponsors)
            {
                person.Introduce();
                person.GetGoal();
            }

            Cohort ocelot = new Cohort("OCELOT");
            ocelot.AddStudent(student);
            ocelot.AddMentor(mentor);

            ocelot.Info();
            Console.ReadLine();
        }
    }
}
