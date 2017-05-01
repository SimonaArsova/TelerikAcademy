using System;
using System.Numerics;
namespace CatalanNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            BigInteger nX2Factorial = 1;
            BigInteger nPlusOneFactorial = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }
            for (int i = 1; i <= n + 1; i++) 
            {
                nPlusOneFactorial *= i;
            }
            for (int i = 1; i <= 2*n; i++)
            {
                nX2Factorial *= i;
            }
            Console.WriteLine(nX2Factorial/nPlusOneFactorial/nFactorial);
        }
    }
}