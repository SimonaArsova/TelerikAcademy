using System;
using System.Numerics;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            BigInteger decimalNumber = 0;
            BigInteger binaryNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger strn = binaryNumber.ToString().Length;
            for (int i = 0; i < strn; i++)
            {
                BigInteger lastDigit = binaryNumber % 10; 
                decimalNumber = decimalNumber + lastDigit * (BigInteger)(Math.Pow(2, i));
                binaryNumber = binaryNumber / 10;
            }
            Console.WriteLine(decimalNumber);
        }
    }
}
