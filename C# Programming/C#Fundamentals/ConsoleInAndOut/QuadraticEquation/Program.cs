using System;
namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = (b * b) - (4 * a * c);

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                if (x1 < x2)
                {
                    Console.WriteLine("{0:0.00}", x1);
                    Console.WriteLine("{0:0.00}", x2);
                }
                else
                {
                    Console.WriteLine("{0:0.00}", x2);
                    Console.WriteLine("{0:0.00}", x1);
                }
            }
            if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("{0:0.00}", x);
            }

            if (D < 0)
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
