using System;

namespace DevideBy7And5
{
    class Startup
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("true "+number);
            }
            else
            {
                Console.WriteLine("false "+number);
            }
        }
    }
}
