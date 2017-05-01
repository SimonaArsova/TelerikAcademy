using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Startup
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Ivanov", 4));
            students.Add(new Student("Petar", "Petrov", 6));
            students.Add(new Student("Dimitar", "Dimitrov", 5));
            students.Add(new Student("Petar", "Ivanov", 2));
            students.Add(new Student("Ivan", "Kostov", 6));
            students.Add(new Student("Mariya", "Petrova", 5));
            students.Add(new Student("Tanya", "Dimitrova", 3));
            students.Add(new Student("Teodora", "Yordanova", 3));
            students.Add(new Student("Yordan", "Dimitrov", 2));
            students.Add(new Student("Ani", "Kostova", 5));

            Console.WriteLine("Students, ordered by grade:\n"+LINQ.OrderStudents(students));
            Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Nikolay", "Ivanov", 250.00));
            workers.Add(new Worker("Simona", "Nikolava", 320.00));
            workers.Add(new Worker("Nikolay", "Simeonov", 120.00));
            workers.Add(new Worker("Daniel", "Dimitrov", 580.00));
            workers.Add(new Worker("Kristina", "Todorova", 460.00));
            workers.Add(new Worker("Todor", "Ivanov", 300.00));
            workers.Add(new Worker("Svetlana", "Valerieva", 280.00));
            workers.Add(new Worker("Valeri", "Cvetanov", 190.00));
            workers.Add(new Worker("Cvetan", "Georgiev", 130.00));
            workers.Add(new Worker("Georgi", "Georgiev", 400.00));

            Console.WriteLine("Workers, ordered by hour salary:\n"+LINQ.OrderWorkers(workers));
            Console.WriteLine();

            Console.WriteLine("People, ordered by their name:");
            var people = (from student in students
                          select new
                          {
                              FirstName = student.FirstName,
                              LastName = student.LastName,
                          }
                                      ).Union(from worker in workers
                                              select new
                                              {
                                                  FirstName = worker.FirstName,
                                                  LastName = worker.LastName,
                                              }).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName + " "+ person.LastName);
            }
            


        }
    }
}
