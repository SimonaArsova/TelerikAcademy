using System;

namespace Calculate
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1;
            long factorial = 1;
            double currentPow = 1;
            for (int i = 1; i <= n; i++)
            {
                currentPow *= x;
                factorial *= i;
                //sum += factorial / Math.Pow(x, i);
                sum += factorial / currentPow;
            }
            Console.WriteLine("{0:F5}", sum);

        }
    }
}
