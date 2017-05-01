using System;
namespace PointCircleRectangle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2);
            if (distance <= Math.Pow(1.5, 2))
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }
            if ((x >= -1) && (x <= (-1 + 6)) && (y <= 1) && (y >= (1 - 6))){
                Console.WriteLine("inside rectangle");
            }
            else
            {
                Console.WriteLine("outside rectangle");
            }
        }
    }
}
