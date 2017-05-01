//using System;

//class SequenceMatrix
//{
//    static void Main()
//    {
//        string[] line = Console.ReadLine().Split(' ');
//        int n = int.Parse(line[0]);
//        int m = int.Parse(line[1]);
//        //Input matrix
//        string[,] matrix = new string[n, m];

//        for (int row = 0; row < matrix.GetLength(0); row++)
//        {
//            string[] rowInput = Console.ReadLine().Split(' ');
//            for (int col = 0; col < matrix.GetLength(1); col++)
//            {
//                matrix[row, col] = rowInput[col];
//            }
//        }

//        int count = 1;
//        int maxCount = 1;
//        //by row
//        for (int row = 0; row < matrix.GetLength(0); row++)
//        {
//            count = 1;
//            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
//            {
//                if (matrix[row, col] == matrix[row, col + 1])
//                {
//                    count++;
//                }
//                else
//                {
//                    count = 1;
//                }

//                if (count > maxCount)
//                {
//                    maxCount = count;
//                }
//            }
//        }
//        //by column
//        for (int col = 0; col < matrix.GetLength(1); col++)
//        {
//            count = 1;
//            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
//            {
//                if (matrix[row, col] == matrix[row + 1, col])
//                {
//                    count++;
//                }
//                else
//                {
//                    count = 1;
//                }

//                if (count > maxCount)
//                {
//                    maxCount = count;
//                }
//            }
//        }
//        //diagonal
//        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//            {
//                count = 1;
//                for (int row = i, col = j; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
//                {
//                    if (matrix[row, col] == matrix[row + 1, col + 1])
//                    {
//                        count++;
//                    }
//                    else
//                    {
//                        count = 1;
//                        break;
//                    }

//                    if (count > maxCount)
//                    {
//                        maxCount = count;
//                    }
//                }
//            }
//        }
//        //secondary diagonal
//        int maxSecondary = 1;
//        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
//        {
//            for (int j = 1; j <matrix.GetLength(1); j++) 
//            {
//                count = 1;
//                for (int row = i + 1, col = j - 1; row < matrix.GetLength(0) - 1 && col > 0; row++, col--) 
//                {
//                    if (matrix[row, col] == matrix[row + 1, col -1]) 
//                    {
//                        count++;
//                    }

//                    if (count > maxSecondary)
//                    {
//                        maxSecondary = count;
//                    }
//                }
//            }
//        }

//        Console.WriteLine( Math.Max(maxCount, maxSecondary+1));

//    }
//}

using System;
using System.Linq;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    {
        static int maxCount = 0;


        static int[,] directions = { { 0, 1 }, { 1, 1 }, { -1, 1 }, { 1, 0 } };


        static int findBestSequence(int[,] matrix)
        {
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int direction = -1;

                    while (++direction < 4)
                    {
                        int _row = row + directions[direction, 0];
                        int _col = col + directions[direction, 1];
                        int currentCount = 1;

                        while (_row >= 0 && _row < matrix.GetLongLength(0) &&
                               _col >= 0 && _col < matrix.GetLongLength(1) &&
                               matrix[_row, _col] == matrix[row, col])
                        {
                            currentCount++;
                            if (currentCount > count)
                            {
                                count = currentCount;
                            }
                            _row += directions[direction, 0];
                            _col += directions[direction, 1];
                        }
                    }
                }
            }
            return count;
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] matrix = new int[n, m];

            //fill matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] tempArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = tempArray[col];

                }
                Array.Clear(tempArray, 0, tempArray.Length);
            }

            maxCount = findBestSequence(matrix);
            Console.WriteLine(maxCount);


        }
    }
}
