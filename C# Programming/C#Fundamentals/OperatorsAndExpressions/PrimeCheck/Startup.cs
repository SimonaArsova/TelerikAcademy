using System;

namespace PrimeCheck
{
    class Startup
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (isPrime(num))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    public static bool isPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
