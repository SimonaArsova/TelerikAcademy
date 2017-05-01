using System;
using System.Linq;
using System.Numerics;
namespace DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            BigInteger decimalNumber = BigInteger.Parse(Console.ReadLine());
            int length = decimalNumber.ToString().Length;
            BigInteger binaryNumber = 0;
            string number = "";

            if (decimalNumber == 0)
            {
                Console.Write(0);
            }

            while (decimalNumber > 0)
            {
                binaryNumber = decimalNumber % 2;
                number = number + binaryNumber.ToString();
                decimalNumber /= 2;
            }
            Console.WriteLine(number.Reverse().Aggregate("", (s, c) => s + c));
        }
    }
}
