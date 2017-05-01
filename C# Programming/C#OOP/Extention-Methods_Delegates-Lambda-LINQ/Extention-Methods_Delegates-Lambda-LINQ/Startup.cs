using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Extention_Methods_Delegates_Lambda_LINQ
{
    class Startup
    {
        static void Main()
        {
            //Problem 1 test
            string text = "Some short text";
            Console.WriteLine(text.SBSubstring(2, 6) + "\n");

            //Problem 2 test
            int[] numbers = { 2, 4, 6, 7, 3 };
            double[] doubleNumbers = { 2.4, 5.6, 14.2, 23.345 };
            Console.WriteLine(numbers.SumElements());
            Console.WriteLine(numbers.MaxElement());
            Console.WriteLine(numbers.MinElement());
            Console.WriteLine(numbers.ProductOfElements());
            Console.WriteLine(numbers.Avg() + "\n");

            Console.WriteLine(doubleNumbers.SumElements());
            Console.WriteLine(doubleNumbers.MaxElement());
            Console.WriteLine(doubleNumbers.MinElement());
            Console.WriteLine(doubleNumbers.ProductOfElements());
            Console.WriteLine(doubleNumbers.Avg() + "\n");

            //Problem 3 test
            Students ivan = new Students("Ivan", "Petrov", 15);
            Students anotherIvan = new Students("Ivan", "Dimitrov", 17);
            Students petar = new Students("Petar", "Ivanov", 20);
            Students mariya = new Students("Mariya", "Dimitrova", 25);
            Students petya = new Students("Petya", "Angelova", 22);
            Students dimitar = new Students("Dimitar", "Kostov", 19);

            Students[] students = { ivan, anotherIvan, petar, mariya, petya, dimitar };
            Console.WriteLine("All students:\n" + string.Join(", ", students) + "\n");
            Console.WriteLine("Students, whose first name is before their last name alphabeticaly:\n" +
                                 LINQ.FirstBeforeLastName(students) + "\n");

            //Problem 4 test
            Console.WriteLine("Students who are between 18 and 24 years old:\n" + LINQ.AgeRange(students) + "\n");
            //Problem 5 test
            Console.WriteLine("Decsending ordered Students:\n" + LINQ.OrderStudents(students) + "\n");

            //Problem 6 test
            int[] nums = { 2, 4, 5, 7, 9, 14, 27 };
            Console.WriteLine("Numbers divisible by 7 and 3:\n" + LINQ.DivisibleBy7And3(nums) + "\n");

            //Problem 7 test - Timer: prints only 5 times so it takes 10seconds 
            Console.WriteLine("Timer:");
            int counter = 0;
            while (counter < 5)
            {
                Thread.Sleep(2000);
                PrintSomething print = Timer.PrintTime;
                print(2);
                counter++;
            }

            //Problem 9 test
            Student ivanIvanov = new Student("Ivan", "Ivanov", 123006, "+359 123123123", "ivan@gmail.com", new List<int> { 2, 3, 5, 4, 5, 2 }, 2);
            Student petyaPetrova = new Student("Petya", "Petrova", 258006, "+359 258258258", "petya@abv.bg", new List<int> { 4, 2, 2, 5, 6, 2 }, 3);
            Student dimitarKolev = new Student("Dimitar", "Kolev", 369008, "02/ 369369369", "mitko@gmail.com", new List<int> { 5, 6, 3, 6, 4, 2 }, 2);

            List<Student> anotherStudents = new List<Student> { ivanIvanov, petyaPetrova, dimitarKolev };
            Console.WriteLine("All students:\n" + string.Join("\r\n", anotherStudents) + "\n");
            Console.WriteLine("Students by group 2:\n" + LINQ.StudentsByGroup2(anotherStudents));

            //Problem 10 test - the same as problem 9 with extension method

            Console.WriteLine(anotherStudents.ByGroup2());

            //Problem 11 test
            Console.WriteLine("Students with e-mail in abv.bg:\n" + LINQ.StudentsAbv(anotherStudents) + "\n");

            //Problem 12 test - Sofia's phone code is 02
            Console.WriteLine("Students with telephones from Sofia:\n" + LINQ.PhonesFromSofia(anotherStudents) + "\n");

            //Problem 13 test
            Console.WriteLine("Students who have least one exellent marks:\n" + LINQ.OneOrMoreExellentMarks(anotherStudents) + "\n");

            //Problem 14 test
            Console.WriteLine("Students who have exactly two poor marks:\n" + string.Join("\r\n", anotherStudents.TwoPoorMarks()) + "\n");

            //Problem 15 test - 5th and 6th digits are 0 and 6
            Console.WriteLine("Students that enrolled in 2006:\n" + string.Join("\r\n", anotherStudents.StudentsIn2006()) + "\n");

            //Problem 17 test
            string[] fruits = { "apple", "orange", "banana", "strawberry" };
            Console.WriteLine("Longest string: " +  LINQ.LongestString(fruits) + "\n");

            //Problem 18 test
            LINQ.GroupByGroup(anotherStudents);

            //Problem 19 test
            anotherStudents.GroupStudents();
        }
    }
}
