using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            uint maskNumber = (uint)Math.Pow(2,k)-1;
            uint mask = ((maskNumber << p) | (maskNumber << q));
            uint firstBitGroup = (uint)((number >> p) & maskNumber);
            uint secondBitGroup = (uint)((number >> q) & maskNumber);
            Console.WriteLine((number & (~mask)) | ((firstBitGroup << q) | (secondBitGroup << p)));
        }
    }
}

