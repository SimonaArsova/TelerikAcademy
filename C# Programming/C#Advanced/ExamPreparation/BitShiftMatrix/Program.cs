using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace BitShiftMatrix
{
    class Program
    {
        static void Main()
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int colsCount = int.Parse(Console.ReadLine());
            int movesCount = int.Parse(Console.ReadLine());

            int[] moves = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();

            var visitedMatrix = new bool[rowsCount, colsCount];
            CycleMatrix(visitedMatrix, moves);
            Console.WriteLine(CalculateSum(visitedMatrix));
        }

        private static BigInteger CalculateSum(bool[,] visitedMatrix)
        {
            int rowsCount = visitedMatrix.GetLength(0);
            int colsCount = visitedMatrix.GetLength(1);
            BigInteger sum = 0;

            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < colsCount; col++)
                {
                    if (visitedMatrix[row, col] == true)
                    {
                        sum += (BigInteger)1 << (rowsCount - row - 1 + col);
                    }
                }
            }
            return sum;
        }

        private static void CycleMatrix(bool[,] visitedMatrix, int[] moves)
        {
            int col = 0;
            int row = visitedMatrix.GetLength(0) - 1;
            int coeff = Math.Max(visitedMatrix.GetLength(0), visitedMatrix.GetLength(1));

            foreach (int move in moves)
            {
                int targetRow = move / coeff;
                int targetCol = move % coeff;

                while (col != targetCol)
                {
                    visitedMatrix[row, col] = true;
                    if (col < targetCol)
                    {
                        col++;
                    }
                    else
                    {
                        col--;
                    }
                }

                while (row != targetRow)
                {
                    visitedMatrix[row, col] = true;
                    if (row < targetRow)
                    {
                        row++;
                    }
                    else
                    {
                        row--;
                    }
                }

                visitedMatrix[row, col] = true;

            }
        }
    }
}
