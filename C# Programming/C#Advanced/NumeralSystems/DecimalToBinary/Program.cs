using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            Console.WriteLine(DecToBinary(number));

        }

        static string DecToBinary(ulong number)
        {
            ulong digit = 0;
            string result = "";
            while (number > 0)
            {
                digit = number % 2;
                result = digit + result;
                number /= 2; 
            }
            return result;
        }
    }
}
