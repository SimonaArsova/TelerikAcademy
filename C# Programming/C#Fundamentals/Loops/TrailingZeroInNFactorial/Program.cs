using System;

namespace TrailingZeroInNFactorial
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int zeros = 0;
            while (num >= 5)
            {
                num /= 5;
                zeros += num;
            }
            Console.WriteLine(zeros);
        }
    }
}
