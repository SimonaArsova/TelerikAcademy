using System;
namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(number));
        }

        static ulong BinaryToDecimal(string number)
        {
            ulong result = 0;
            foreach (char digit in number)
            {
                result = result * 2 + (ulong) (digit - '0');
            }
            return result;
        }
    }
}
