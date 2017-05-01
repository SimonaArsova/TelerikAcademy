using System;

namespace FourDigits
{
    class Startup
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int firstDigit = (number / 1000) % 10;
            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number / 10) % 10;
            int lastDigit = number % 10;
            Console.WriteLine(firstDigit + secondDigit + thirdDigit + lastDigit);
            Console.WriteLine("{0}{1}{2}{3}", lastDigit, thirdDigit, secondDigit, firstDigit);
            Console.WriteLine("{0}{1}{2}{3}", lastDigit, firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, lastDigit);

        }
    }
}
