using System;
namespace FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            int index = 1;

            switch (ch)
            {
                case 'a':
                    for (int col = 0; col < n; col++)
                    {
                        for (int row = 0; row < n; row++)
                        {
                            arr[row, col] = index;
                            index++;
                        }
                    }
                    break;

                case 'b':
                    for (int col = 0; col < n; col ++)
                    {
                        if (col % 2 == 0)
                        {
                            for (int row = 0; row < n; row++)
                            {
                                arr[row, col] = index;
                                index++;
                            }
                        }
                        else
                        {
                            for (int row = n - 1; row >= 0; row--)
                            {
                                arr[row, col] = index;
                                index++;
                            }
                        }
                    }
                    break;

                case 'c':
                    for (int reversedRow = n - 1; reversedRow >= 0; reversedRow--)
                    {
                        for (int col = 0; col < (n - reversedRow); col++)
                        {
                            arr[(reversedRow + col), col] = index;
                            index++;
                        }
                    }
                    for (int col = 1; col <= n - 1; col++)
                    {
                        for (int row = 0; row < (n - col); row++)
                        {
                            arr[row, (col + row)] = index;
                            index++;
                        }
                    }
                    break;

                case 'd':
                   for (int depth = 0; depth <= (n / 2); depth++)
            {
                for (int down = depth; down <= n - depth - 1; down++, index++)
                {
                    arr[down, depth] = index;
                }
                for (int right = depth + 1; right <= n - depth - 1; right++, index++)
                {
                    arr[(n - depth - 1), right] = index;
                }
                for (int up = n - depth - 2; up > depth; up--, index++)
                {
                    arr[up, (n - depth - 1)] = index;
                }
                for (int left = n - depth - 1; left > depth; left--, index++)
                {
                    if (arr[depth, left] == 0)
                    {
                        arr[depth, left] = index;
                    }
                    else
                    {
                        break;
                    }
                }
            }
                    break;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i,j]);
                    if (j + 1 == n)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}