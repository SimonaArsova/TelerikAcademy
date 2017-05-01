using System;

namespace BitExchange
{
    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            uint mask = ((7 << 3) | (7 << 24));
            uint firstBits = (number >> 3) & 7;
            uint lastBits = (number >> 24) & 7;
            Console.WriteLine((number & (~mask)) | ((firstBits << 24) | (lastBits << 3)));
        }
    }
}
