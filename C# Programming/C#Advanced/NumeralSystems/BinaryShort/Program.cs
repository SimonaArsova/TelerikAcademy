using System;

namespace BinaryShort
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number,2).PadLeft(16,'0'));
            //    PrintBits(number);
            //}

            //static void PrintBits(int number)
            //{
            //    string result = null;
            //    for (int i = 0; i < 16; i++)
            //    {
            //        int mask = 1 << i;
            //        int bit = (mask & number) >> i;
            //        result = bit + result;
            //    }

            //    Console.WriteLine(result);
        }
    }
}
