using System;

namespace MythicalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int[] arr = new int[3];
            double result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                arr[i] = number[i] - '0';
            }

            if (arr[2] == 0)
            {
                result = arr[0] * arr[1];
            }
            else if (arr[2] > 0 && arr[2] <= 5)
            {
                result = (arr[0] * arr[1]) / (double)arr[2];
            }
            else
            {
                result = (arr[0] + arr[1]) * arr[2];
            }
            Console.WriteLine("{0:0.00}",result);
        }
    }
}
