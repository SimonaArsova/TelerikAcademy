using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            int[,] matrix = new int[n,m];
            int sum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < m; j++)
                {
                    matrix[i,j] = row[j];
                }
            }

            for (int row = 0; row < n-2; row++)
            {
                for (int col = 0; col < m-2; col++)
                {
                    sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2] +
                          matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                    sum = 0;        
                }
            }
            Console.WriteLine(maxSum);

        }
    }
}
