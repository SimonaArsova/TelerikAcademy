using System;

namespace Sequence
{
    class Program
    {
        static void Main()
        {
            for(int i = 2; i < 12; i++)
            {
                Console.WriteLine((Math.Pow(-1, i)*i));
            }
     
        }
    }
}
