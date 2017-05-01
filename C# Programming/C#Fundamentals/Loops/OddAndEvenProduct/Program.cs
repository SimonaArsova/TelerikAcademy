using System;

namespace OddAndEvenProduct
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            long evenProduct = 1;
            long oddProduct = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    evenProduct *= int.Parse(numbers[i]);
                }
                else
                {
                    oddProduct *= int.Parse(numbers[i]);
                }
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes "+ oddProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", evenProduct, oddProduct);
            }
        }
    }
}
