using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            if (Math.Abs(x - y) < eps|| Math.Abs(y - x) < eps)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
