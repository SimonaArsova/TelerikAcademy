using System;

namespace Traapezoids
{
    class Program
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(((sideA + sideB) * height / 2).ToString("0.0000000"));
        }
    }
}
