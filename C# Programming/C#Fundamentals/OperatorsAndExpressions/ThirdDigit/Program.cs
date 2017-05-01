using System;
namespace ThirdDigit
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int wrongN = (n / 100) % 10;
            if (wrongN == 7)
            {
                Console.WriteLine("true ");
            }
            else
            {
                Console.WriteLine("false "+ wrongN);
            }
        }
    }
}
