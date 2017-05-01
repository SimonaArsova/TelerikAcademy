using System;
namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long a = 0;
            long b = 1;
                Console.Write(a);
                for (int i = 1; i < n; i++)
                {
                    long temp = a;
                    a = b;
                    b += temp;
                    Console.Write(", {0}", a);
                }
        }
    }
}
