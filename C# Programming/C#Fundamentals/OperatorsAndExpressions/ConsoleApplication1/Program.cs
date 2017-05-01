using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            long p = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((p >> n) & 1);
        }
    }
}
