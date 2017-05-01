namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Mines
    {
        public static void Main(string[] arguments)
        {
            string command = string.Empty;
            char[,] matrix = MakeMatrix();
            char[,] bombs = PutBombs();
            int counter = 0;
            bool hasTheBombExploded = false;
            List<Points> champions = new List<Points>(6);
            int row = 0;
            int column = 0;
            bool isNewGame = true;
            const int Max = 35;
            bool isGameOver = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play \"Mines\". Try your luck and find the fields without a mine. Press 'top' to see the results, 'restart' - to start a new game and 'exit' to exit.");
                    PrintGameMatrix(matrix);
                    isNewGame = false;
                }

                Console.Write("Enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= matrix.GetLength(0) && column <= matrix.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintTopResults(champions);
                        break;
                    case "restart":
                        matrix = MakeMatrix();
                        bombs = PutBombs();
                        PrintGameMatrix(matrix);
                        hasTheBombExploded = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                TakeMatrixValue(matrix, bombs, row, column);
                                counter++;
                            }

                            if (Max == counter)
                            {
                                isGameOver = true;
                            }
                            else
                            {
                                PrintGameMatrix(matrix);
                            }
                        }
                        else
                        {
                            hasTheBombExploded = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command\n");
                        break;
                }

                if (hasTheBombExploded)
                {
                    PrintGameMatrix(bombs);
                    Console.Write("\nYou died heroic with {0} points. Enter your nickname:", counter);
                    string nickName = Console.ReadLine();
                    Points t = new Points(nickName, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Score < t.Score)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Points r1, Points r2) => r2.Score.CompareTo(r1.Score));
                    PrintTopResults(champions);

                    matrix = MakeMatrix();
                    bombs = PutBombs();
                    counter = 0;
                    hasTheBombExploded = false;
                    isNewGame = true;
                }

                if (isGameOver)
                {
                    Console.WriteLine("\nYou win!");
                    PrintGameMatrix(bombs);
                    Console.WriteLine("Please enter your name: ");
                    string name = Console.ReadLine();
                    Points points = new Points(name, counter);
                    champions.Add(points);
                    PrintTopResults(champions);
                    matrix = MakeMatrix();
                    bombs = PutBombs();
                    counter = 0;
                    isGameOver = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");

            Console.Read();
        }

        private static void PrintTopResults(List<Points> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, points[i].Name, points[i].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty chart!\n");
            }
        }

        private static void TakeMatrixValue(char[,] matrix, char[,] bombs, int row, int column)
        {
            char numberOfBombs = CountMines(bombs, row, column);
            bombs[row, column] = numberOfBombs;
            matrix[row, column] = numberOfBombs;
        }

        private static void PrintGameMatrix(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] MakeMatrix()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PutBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] matrix = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = '-';
                }
            }

            List<int> numbers = new List<int>();
            while (numbers.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!numbers.Contains(randomNumber))
                {
                    numbers.Add(randomNumber);
                }
            }

            foreach (int num in numbers)
            {
                int column = num / columns;
                int row = num % columns;
                if (row == 0 && num != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                matrix[column, row - 1] = '*';
            }

            return matrix;
        }

        private static void GetNeighbourMinesCount(char[,] matrix)
        {
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (matrix[i, j] != '*')
                    {
                        char neighbourMines = CountMines(matrix, i, j);
                        matrix[i, j] = neighbourMines;
                    }
                }
            }
        }

        private static char CountMines(char[,] matrix, int row, int column)
        {
            int counter = 0;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            if (row - 1 >= 0)
            {
                if (matrix[row - 1, column] == '*')
                {
                    counter++;
                }
            }

            if (row + 1 < rows)
            {
                if (matrix[row + 1, column] == '*')
                {
                    counter++;
                }
            }

            if (column - 1 >= 0)
            {
                if (matrix[row, column - 1] == '*')
                {
                    counter++;
                }
            }

            if (column + 1 < columns)
            {
                if (matrix[row, column + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (matrix[row - 1, column - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (matrix[row - 1, column + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (matrix[row + 1, column - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (matrix[row + 1, column + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }

        public class Points
        {
            private string name;
            private int score;

            public Points()
            {
            }

            public Points(string name, int score)
            {
                this.name = name;
                this.score = score;
            }

            public string Name
            {
                get
                {
                    return this.name;
                }

                set
                {
                    this.name = value;
                }
            }

            public int Score
            {
                get
                {
                    return this.score;
                }

                set
                {
                    this.score = value;
                }
            }
        }
    }
}
