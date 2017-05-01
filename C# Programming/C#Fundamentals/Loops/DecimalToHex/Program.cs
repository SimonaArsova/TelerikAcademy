using System;

namespace DecimalToHex
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            string result = "";

            while (number != 0)
            {
                if ((number % 16) < 10)
                    result = number % 16 + result;
                else
                {
                    string temp = "";

                    switch (number % 16)
                    {
                        case 10: temp = "A"; break;
                        case 11: temp = "B"; break;
                        case 12: temp = "C"; break;
                        case 13: temp = "D"; break;
                        case 14: temp = "E"; break;
                        case 15: temp = "F"; break;
                    }

                    result = temp + result;
                }

                number /= 16;
            }
            Console.WriteLine(result);
        }
    }
}
