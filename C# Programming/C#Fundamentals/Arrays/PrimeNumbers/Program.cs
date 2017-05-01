using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            if (number == 1 || number == 0) return false;
            if (number == 2) return true;
 
            int half = number / 2;
            for (int i = 2; i <= half; ++i)
            {
                if (number % i == 0) return false;
            }
 
            return true;
        }
 
        private static List<int> CalculatePrimesInRange(int startNumber, int endNumber)
        {
            List<int> numbers=new List<int>();
 
            for (int i = endNumber; i >startNumber; i--)
            {
                if(IsPrime(i))
                {
                    numbers.Add(i);
                    break;
                }
            }
            return numbers;
        }
 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = CalculatePrimesInRange(1, n).ToArray();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
