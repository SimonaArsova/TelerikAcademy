using System;

namespace HexToDecimal
{
    class Program
    {
        static void Main()
        {
            string hexNumber = Console.ReadLine();
            long result = 0;
            int count = hexNumber.Length - 1;
            for (int i = 0; i < hexNumber.Length; i++)
            {
                int temp = 0;
                switch (hexNumber[i])
                {
                    case 'A': temp = 10; break;
                    case 'B': temp = 11; break;
                    case 'C': temp = 12; break;
                    case 'D': temp = 13; break;
                    case 'E': temp = 14; break;
                    case 'F': temp = 15; break;
                    default: temp = -48 + hexNumber[i]; break; // -48 because of ASCII
                }

                result += temp * (long)(Math.Pow(16, count));
                count--;
            }
            Console.WriteLine(result);
        }
    }
}
