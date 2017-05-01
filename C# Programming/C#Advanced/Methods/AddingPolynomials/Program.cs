using System;
using System.Linq;

namespace AddingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            SumPolindroms(firstArray, secondArray);
        }

        static void SumPolindroms(int[] firstArray, int[] secondArray)
        {
            int[] sum = new int[firstArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                sum[i] =  (firstArray[i] + secondArray[i]);
            }
            
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write("{0} ", sum[i]);
            }
        }
    }
}
