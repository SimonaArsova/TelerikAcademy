using System;
namespace AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(line.Split(' ')[i]);
            }

            CountX(numbers, x);
        }

       static void CountX(int[]numbers, int x)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (x == numbers[i])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
