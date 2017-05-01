using System;

namespace MixingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int multResult = 0;
            int subResult = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                multResult = (arr[i] % 10) * (arr[i + 1] / 10);
                Console.Write(multResult + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < n - 1; i++)
            {
                subResult = arr[i] - arr[i + 1];
                if (subResult < 0)
                {
                    subResult = -(subResult);
                }
                Console.Write(subResult + " ");
              
            }
        }
    }
}
