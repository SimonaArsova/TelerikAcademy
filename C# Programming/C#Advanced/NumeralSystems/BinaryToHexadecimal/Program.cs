using System;

namespace BinaryToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(DecToHexadecimal(number));
        }

        static ulong BinaryToDecimal(string number)
        {
            ulong result = 0;
            foreach (char digit in number)
            {
                result = result * 2 + (ulong)(digit - '0');
            }
            return result;
        }

        static string DecToHexadecimal(string number)
        {
            ulong decResult = BinaryToDecimal(number);
            string result = "";
            char[] hexDigits = "0123456789ABCDEF".ToCharArray();
            while (decResult > 0)
            {
                ulong digitValue = decResult % 16;
                char digit = hexDigits[digitValue];
                result = digit + result;
                decResult /= 16;
            }
            return result;
        }
    }
}
