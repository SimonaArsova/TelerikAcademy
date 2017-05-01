using System;

namespace ThirdBit
{
    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine((number >> 3) & 1);
        }
    }
}
