using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorTheLoop
{
    class Loop
    {
        static void Main(string[] args)
        {
            int i;
            int[] array = new int[100];
            int expectedValue = 42;
            const int DIVIDER = 10;

            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if ((array[i] == expectedValue) && (i % DIVIDER == 0))
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }
            // More code here
        }
    }
}
