using System;
namespace MaximalSum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            int maxSum = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
                if (maxSum <= sum)
                {
                    maxSum = sum;
                }
                else if (sum < 0)
                {
                    sum = 0;
                }
            }
            Console.WriteLine(maxSum);
        }
    }

}
