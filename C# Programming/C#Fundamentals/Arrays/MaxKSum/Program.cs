using System;

namespace MaxKSum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int i = n - 1; i > n - k - 1; i--)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);
        }
    }
}
