
using System;
namespace Sort3Numbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a >= b)
            {
                if (b >= c)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                else if (c > b && c <= a)
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
                else
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
            }
            else if (b > a)
            {
                if (a >= c)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else if (c > a && c < b)
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
                else
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }
        }
    }
}
