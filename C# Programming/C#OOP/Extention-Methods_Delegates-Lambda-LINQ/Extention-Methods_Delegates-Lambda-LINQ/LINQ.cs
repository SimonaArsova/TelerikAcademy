using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Methods_Delegates_Lambda_LINQ
{
   public static class LINQ
    {
        //Problem 3
        public static string FirstBeforeLastName(Students[] students)
        {
            var newStudents = students.Where(s => s.FirstName.CompareTo(s.LastName) < 0);
            return String.Join(", ", newStudents);
        }

        //Problem 4
        public static string AgeRange(Students[] students)
        {
            var newStudents = students.Where(s => s.Age >= 18 && s.Age <= 24);
            return String.Join(", ", newStudents);
        }

        //Problem 5
        public static string OrderStudents(Students[] students)
        {
            var newStudents = students.OrderByDescending(s=> s.FirstName)
                                      .ThenByDescending(s=> s.LastName);
            return String.Join(", ", newStudents);
        }

        //Problem 6
        public static string DivisibleBy7And3(int[] numbers)
        {
            var newNumbers = numbers.Where(n => n % 3 == 0 || n % 7 == 0);
            return String.Join(", ", newNumbers);
        }

        //Problem 9
        public static string StudentsByGroup2(List<Student> students)
        {
            var newSt = students.Where(s => s.GroupNumber == 2)
                          .OrderBy(s => s.FirstName);
            return String.Join("\r\n", newSt);
        }

        //Problem 11
        public static string StudentsAbv(List<Student> students)
        {
            var newSt = students.Where(s => s.Email.EndsWith("abv.bg"));
            return String.Join("\r\n", newSt);
        }

        //Problem 12
        public static string PhonesFromSofia(List<Student> students)
        {
            var newSt = students.Where(s => s.Tel.StartsWith("02/"));
            return String.Join("\r\n", newSt);
        }

        //Problem 13
        public static string OneOrMoreExellentMarks(List<Student> students)
        {
            var newSt = students.Where(s => s.Marks.IndexOf(6) != -1);
            return String.Join("\r\n", newSt);
        }

        //Problem 17
        public static string LongestString(string[] students)
        {
            var newSt = students.OrderByDescending(s => s.Length).First();
            return newSt;
        }

        //Problem 18
        public static void GroupByGroup(List<Student> students)
        {
            var selectStudentsLINQ =
                from student in students
                group student by student.GroupNumber into g
                select g;

            foreach (var group in selectStudentsLINQ)
            {
                Console.WriteLine("Group " + group.Key+ ":");

                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }
        }

    }
}
