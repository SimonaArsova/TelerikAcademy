using System;

namespace HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(HexToDecimal(number));
        }

        static ulong HexToDecimal(string number)
        {
            ulong result = 0;
            foreach (char digit in number)
            {
                if (char.IsDigit(digit))
                {
                    result = result * 16 + digit - '0';
                }
                else
                {
                    result = result * 16 + (ulong)(digit - 'A' + 10);
                }
                
            }
            return result;
        }
    }
}
