using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Methods_Delegates_Lambda_LINQ
{
   public static class ExtentionMethods
    {
        //Problem 1
        public static StringBuilder SBSubstring(this string text, int index, int length)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = index; i < length + index; i++)
            {
                builder.Append(text[i]);
            }
            return builder;
        }

        //Problem 2
        public static T SumElements<T>(this IEnumerable<T> sequence)
        {
            T sum = default(T);
            foreach (dynamic element in sequence)
            {
                sum += element;
            }
            return sum;
        }

        public static T ProductOfElements<T>(this IEnumerable<T> sequence)
        {
            dynamic product = 1;
            foreach (dynamic element in sequence)
            {
                product *= element;
            }
            return product;
        }

        public static T MaxElement<T>(this IEnumerable<T> sequence)
        {
            return Enumerable.Max(sequence);
        }

        public static T MinElement<T>(this IEnumerable<T> sequence)
        {
            return Enumerable.Min(sequence);
        }

        public static double Avg<T>(this IEnumerable<T> sequence)
        {
            return sequence.SumElements() /(dynamic) sequence.Count();
        }

        //Problem 10

        public static string ByGroup2(this List<Student> students)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var student in students)
            {
                if (student.GroupNumber == 2)
                {
                    sb.Append(student);
                    sb.Append("\r\n");
                }
            }
            return sb.ToString();
        }

        //Problem 14
        public static List<Student> TwoPoorMarks(this List<Student> students)
        {
            List<Student> newStudents = new List<Student>();
            int counter = 0;
            foreach (var student in students)
            {
                foreach (var mark in student.Marks)
                {
                    if (mark == 2)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    newStudents.Add(student);
                }
            }
            return newStudents;
        }

        //Problem 15
        public static List<Student> StudentsIn2006(this List<Student> students)
        {
            List<Student> newStudents = new List<Student>();
            char[] fn;
            foreach (var student in students)
            {
                fn = student.FN.ToString().ToArray();
                if (fn[4] == '0' && fn[5] == '6')
                {
                    newStudents.Add(student);
                }
            }
            return newStudents;
        }

        //Problem 19
        public static void GroupStudents(this List<Student> students)
        {
            var selectStudents =students.GroupBy(st => st.GroupNumber).ToList();

            foreach (var group in selectStudents)
            {
                Console.WriteLine("Group " + group.Key + ":");
                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }
        }

    }
}
