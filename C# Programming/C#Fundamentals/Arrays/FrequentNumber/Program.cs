using System;

namespace FrequentNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 1;
            int maxCounter = 1;
            int freqNumber = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            for (int i = 0; i < n-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                    if (maxCounter <= counter)
                    {
                        maxCounter = counter;
                        freqNumber = arr[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine("{0} ({1} times)",freqNumber, maxCounter);
        }
    }
}
