using System;

namespace PointInCircle
{
    class Startup
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = x * x + y * y;
            if (distance <= 4.0)
            {
                Console.WriteLine("yes " + Math.Sqrt(distance).ToString("0.00"));
            }
            else
            {
                Console.WriteLine("no " + Math.Sqrt(distance).ToString("0.00"));
            }

        }
    }
}
