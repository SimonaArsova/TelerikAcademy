using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Startup
    {
        static void Main()
        {
            Class newClass = new Class();
            Teacher ivan = new Teacher("Ivan Ivanov");
            Teacher petar = new Teacher("Petar Petrov");
            newClass.AddTeacher(ivan);
            newClass.AddTeacher(petar);
            Discipline maths = new Discipline("Maths", 4, 4);
            Discipline physics = new Discipline("Physics", 2, 3);
            ivan.AddDiscipline(maths);
            ivan.AddDiscipline(physics);
            petar.AddDiscipline(maths);

            Console.WriteLine(newClass);

            foreach (var teacher in newClass.Teachers)
            {
                Console.WriteLine(teacher);
                teacher.showDisciplines();
            }
            Console.WriteLine();

            Student petya = new Student("Petya Petkova");
            Student mariya = new Student("Mariya Petkova");
            Student tanya = new Student("Tanya Petkova");
            newClass.AddStudent(petya);
            newClass.AddStudent(mariya);
            newClass.AddStudent(tanya);

            foreach (var item in newClass.Students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
