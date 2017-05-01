using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            char[] digits = number.ToCharArray();
            ReverseNumber(digits);
        }

       static void ReverseNumber(char[] digits)
        {
            Array.Reverse(digits);
            Console.WriteLine(digits);
        }
    }
}
