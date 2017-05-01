using System;
using System.Numerics;
namespace CalculateAgain
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger kFactorial=1;
            BigInteger nFactorial=1;

            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
                if (i <= k)
                {
                    kFactorial *= i;
                }
            }
            Console.WriteLine(nFactorial/kFactorial);
        }
    }
}
