using System;

namespace MaxIncreasingSequense
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 1;
            int max = 1;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    counter++;
                    if (max <= counter)
                    {
                        max = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine(max);
        }
    }
}
