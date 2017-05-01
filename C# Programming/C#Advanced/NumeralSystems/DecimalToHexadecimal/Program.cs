using System;
namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            Console.WriteLine(DecToHexadecimal(number));

        }

        static string DecToHexadecimal(ulong number)
        {
            string result = "";
            char[] hexDigits = "0123456789ABCDEF".ToCharArray();
            while (number > 0)
            {
                ulong digitValue = number % 16;
                char digit = hexDigits[digitValue];
                result = digit + result;
                number /= 16;
            }
            return result;
        }
    }
}
