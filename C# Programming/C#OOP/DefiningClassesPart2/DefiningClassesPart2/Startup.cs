using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    
    class Startup
    {
        static void Main()
        {
            //Problem 1 test
            Console.WriteLine("Point:");    
            Point3D point= new Point3D(2.5, 3, 4);  
            Console.WriteLine(point.ToString());
            //Problem 2 test
            Console.WriteLine("\nPoint O:");    
            Console.WriteLine(Point3D.getPointO.ToString());
            //Problem 3 test
            Console.WriteLine("\nDistance between two points:");     
            Console.WriteLine(Distance.CalculateDistance(Point3D.getPointO, point));

            //Problem 4 test
            Console.WriteLine("\nPath:");    
            Path.PointsPath.Add(new Point3D(7, 3, 1)); 
            Path.PointsPath.Add(new Point3D(3, 1, 9));
            Path.PointsPath.Add(new Point3D(5, 5, 9));
            PathStorage.SavePath();
            Console.WriteLine(PathStorage.LoadPaths());

            //Problems 5, 6 test
            var numbers = new GenericList<int>(4); 
            numbers.Add(5);     //Test Add method
            numbers.Add(45);
            numbers.Add(34);
            numbers.Add(3);
            numbers.Add(423);
            numbers.Add(3247);
            Console.WriteLine(numbers);

            var people = new GenericList<string>(2);    //Test GenericList with strings
            people.Add("Ivan");
            people.Add("Petar");
            people.Add("Dimitar");
            people.Add("Georgi");
            Console.WriteLine(people);
            Console.WriteLine();

            numbers.RemoveAtGivenPosition(3);   //Test RemoveAtGivenPosition method
            numbers.RemoveAtGivenPosition(1);
            Console.WriteLine(numbers);
            people.RemoveAtGivenPosition(0);
            Console.WriteLine(people);
            Console.WriteLine();

            numbers[0] = 555;   //Test indexer
            Console.WriteLine(numbers);
            people[2] = "Mariya";
            Console.WriteLine(people);
            Console.WriteLine();

            numbers.AddAtGivenPosition(999, 0);     //Test AddAtGivenPosition method
            numbers.AddAtGivenPosition(11, 0);
            Console.WriteLine(numbers);
            people.AddAtGivenPosition("Petya", 0);
            Console.WriteLine(people);
            Console.WriteLine();
            
            Console.WriteLine("Index of 555: "+numbers.IndexOf(555) + ", Index of 3247: " + numbers.IndexOf(3247)); // Test IndexOf method
            Console.WriteLine("Index of Mariya: " + people.IndexOf("Mariya"));
            Console.WriteLine();

            //Problem 7 test
            Console.WriteLine("Min element of numbers: "+numbers.Min());   //Test Min method
            Console.WriteLine("Max element of numbers: "+numbers.Max());   //Test Max method
            Console.WriteLine("Min element of names:" + people.Min());
            Console.WriteLine("Max element of names:" + people.Max());
            Console.WriteLine();

            numbers.RemoveAll();    //Test RemoveAll method(Problem 6)
            Console.WriteLine(numbers);
            people.RemoveAll();
            Console.WriteLine(people);
            Console.WriteLine();

            //Problems 8,9
            var matrix = new Matrix<double>();
            matrix[2, 1] = 2.4;
            matrix[4, 2] = 10.3;
            matrix[1, 0] = 45.4;
            Console.WriteLine(matrix[2, 1] + ", " + matrix[4, 2] + ", " + matrix[1, 0]);

            var numberMatrix = new Matrix<int>();
            matrix[3, 1] = 2;
            matrix[1, 2] = 10;
            matrix[2, 0] = 45;
            Console.WriteLine(matrix[3, 1] + ", " + matrix[1, 2] + ", " + matrix[2, 0]+"\n");

            //Problem 10
            var firstMatrix = new Matrix<int>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    firstMatrix[i, j] = i + 1;
                }
            }

            var secondMatrix = new Matrix<int>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    secondMatrix[i, j] = i + 2;
                }
            }
            Console.WriteLine(firstMatrix);
            Console.WriteLine();
            Console.WriteLine(secondMatrix);
            Console.WriteLine();
            Console.WriteLine(firstMatrix + secondMatrix);
            Console.WriteLine();
            Console.WriteLine(secondMatrix - firstMatrix);
            Console.WriteLine();
            Console.WriteLine(firstMatrix * secondMatrix);
            Console.WriteLine();

            //Problem 11
            VersionAttribute vs = new VersionAttribute();
            vs.getVersion();

        }
    }
}
