using System;

namespace HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(HexToBinary(number));
        }

        static string HexToBinary(string number)
        {
            ulong hexResult = 0;
            string result = "";
            foreach (char digit in number)
            {
                if (char.IsDigit(digit))
                {
                    hexResult = hexResult * 16 + digit - '0';
                }
                else
                {
                    hexResult = hexResult * 16 + (ulong)(digit - 'A' + 10);
                }
                result = DecToBinary(hexResult);
            }
            return result;
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
