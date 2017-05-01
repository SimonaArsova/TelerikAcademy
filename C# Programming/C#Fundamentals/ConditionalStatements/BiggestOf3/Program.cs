using System;

namespace BiggestOf3
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if ((a > b && a > c) || (a == b && b == c))
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c) 
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
