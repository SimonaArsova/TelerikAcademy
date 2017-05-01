using System;
namespace SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(line.Split(' ')[i]);
            }

            SortArray(numbers);
        }

        static void SortArray(int[] numbers)
        {
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}
