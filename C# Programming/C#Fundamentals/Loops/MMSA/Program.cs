using System;
using System.Linq;

namespace MMSA
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("min={0:0.00}", arr.Min());
            Console.WriteLine("max={0:0.00}", arr.Max());
            Console.WriteLine("sum={0:0.00}", arr.Sum());
            Console.WriteLine("avg={0:0.00}", arr.Average());
        }
    }
}
