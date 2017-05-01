using System;

namespace QuickSort
{
    class QuickSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            quickSort(numbers, 0, numbers.Length - 1);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static public int Partition(int[] numbers, int left, int right)
        {
            int temp;
            int p = numbers[right];
            int i = left - 1;

            for (int j = left; j <= right - 1; j++)
            {
                if (numbers[j] <= p)
                {
                    i++;
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }

            temp = numbers[i + 1];
            numbers[i + 1] = numbers[right];
            numbers[right] = temp;
            return i + 1;
        }

        static public void quickSort(int[] numbers, int left, int right)
        {
            int i;
            if (left < right)
            {
                i = Partition(numbers, left, right);

                quickSort(numbers, left, i - 1);
                quickSort(numbers, i + 1, right);
            }
        }
    }
}