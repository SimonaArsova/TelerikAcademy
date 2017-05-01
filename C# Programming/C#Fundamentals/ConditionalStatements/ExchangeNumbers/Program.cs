using System;
namespace ExchangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a <= b)
            {
                Console.WriteLine(a + " " + b);
            }
            else if (a > b)
            {
                Console.WriteLine(b + " " + a);
            }
        }
    }
}
