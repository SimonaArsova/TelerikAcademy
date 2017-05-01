using System;

namespace ModifyBit
{
    class Program
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            ulong position = ulong.Parse(Console.ReadLine());
            ulong value = ulong.Parse(Console.ReadLine());
            if(value == 0)
            {
                Console.WriteLine(number & (ulong)~(1 << (int)position));
            }
            else
            {
                Console.WriteLine(number | (ulong)1 << (int)position);
            }
        }
    }
}
