using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyCodingHours = 6;
            int semesterWeeks = 17;
            int avgWeeklyWorkHours = 52;
            double finalCodingHours1 = (dailyCodingHours * 5) * semesterWeeks;
            double finalCodingHours2 = avgWeeklyWorkHours* semesterWeeks;

            Console.WriteLine(finalCodingHours1);
            Console.WriteLine(finalCodingHours2);

            Console.WriteLine((finalCodingHours1/finalCodingHours2) * 100);


            Console.ReadLine();
            
        }
    }
}
