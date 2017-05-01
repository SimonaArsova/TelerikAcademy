using System;
using System.Collections.Generic;

namespace RemoveElementsFromArray
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maxSubLength = 0;
            int[] tempArray = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                maxSubLength = 0;

                for (int j = 0; j < n; j++)
                {
                    if (numbers[j] <= numbers[i] && tempArray[j] >= maxSubLength)
                    {
                        maxSubLength = tempArray[j];
                    }
                }
                tempArray[i] = maxSubLength + 1;
            }

            maxSubLength = 0;
            for (int i = 0; i < n; i++)
            {
                if (tempArray[i] > maxSubLength)
                {
                    maxSubLength = tempArray[i];
                }
            }
            Console.WriteLine(n - maxSubLength);
        }
    }
}