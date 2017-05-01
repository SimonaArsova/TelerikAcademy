using System;
using System.Linq;

namespace IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            MMASP(numbers);
        }

        static void MMASP(int[] numbers)
        {
            long product = 1;
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine("{0:0.00}",numbers.Average());
            Console.WriteLine(numbers.Sum());
            foreach(int n in numbers)
            {
                product *= n;
            }
            Console.WriteLine(product);
        }
    }
}
