using System;
namespace LargerThanNeighbours
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

            IsLarger(numbers);
        }

       static void IsLarger(int[] numbers)
        {
            int counter = 0;
            for (int i = 1; i < numbers.Length-1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
