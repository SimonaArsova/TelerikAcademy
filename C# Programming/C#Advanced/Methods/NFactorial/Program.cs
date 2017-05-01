using System;
using System.Numerics;
namespace NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Factorial(n);
        }

        static void Factorial(int n)
        {
            BigInteger factorial = 1;
            if (n == 0 || n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
            }

        }
    }
}
