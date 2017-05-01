using System;
using System.Linq;

class LargestAreaMatrix
{
    static int[,] matrix;
    static bool[,] visited;

    public static void Main()
    {
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            matrix = new int[n, m];
            visited = new bool[n, m];

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            MaxCount(n, m);
        }
    }

    private static void MaxCount(int n,int m)
    {
        int maxCount = 0;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                int currentCount = DepthFirstSearch(matrix[row, col], row, col);
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
        }

        Console.WriteLine(maxCount);
    }

    private static int DepthFirstSearch(int value, int row, int col)
    {
        if (visited[row, col])
        {
            return 0;
        }
        int result = 1;
        visited[row, col] = true;

        if (row + 1 < matrix.GetLength(0) && matrix[row + 1, col] == value && !visited[row + 1, col])
        {
            result += DepthFirstSearch(value, row + 1, col);
        }
        if (row - 1 >= 0 && matrix[row - 1, col] == value && !visited[row - 1, col])
        {
            result += DepthFirstSearch(value, row - 1, col);
        }
        if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == value && !visited[row, col + 1])
        {
            result += DepthFirstSearch(value, row, col + 1);
        }
        if (col - 1 >= 0 && matrix[row, col - 1] == value && !visited[row, col - 1])
        {
            result += DepthFirstSearch(value, row, col - 1);
        }


        return result;
    }
    

}