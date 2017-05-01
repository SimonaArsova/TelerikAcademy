using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            
            int innerSquares = (int)Math.Ceiling(n / 2.0);
            int currentSideLength = n;
            int counter = 1;

            for (int i = 0; i < innerSquares; i++)
            {
                // fill in top side
                for (int j = 0; j < currentSideLength; j++)
                {
                    matrix[i + j, i] = counter++;
                }
                // fill in right side
                for (int j = 1; j < currentSideLength; j++)
                {
                    matrix[n - 1 - i, i + j] = counter++;
                }
                // fill in bottom side
                for (int j = currentSideLength - 2; j > -1; j--)
                {
                    matrix[i + j, n - 1 - i] = counter++;
                }
                // fill in left side
                for (int j = currentSideLength - 2; j > 0; j--)
                {
                    matrix[i, i + j] = counter++;
                }
                // After finishing with the current square,  the next one has 2 less sides
                currentSideLength -= 2;
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[j, i]);
                }
                Console.WriteLine();
            }

        }
    }
}
