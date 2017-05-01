using System;
using System.Linq;

namespace GetLargestNumber
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[3];
            string input = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(input.Split(' ')[i]);
            }
            GetMax(numbers);
        }

        static void GetMax(int[] numbers)
        {
            Console.WriteLine(numbers.Max());
        }
    }
}
