using System;
using WalkInMatrix.Models;
using WalkInMatrix.Utils;

namespace WalkInMatrix
{
    public class Startup
    {
        private const string EnterAPositiveNumber = "Enter a positive number between 1 and 100 inclusive";
        private const string InvalidNumberErrorMessage = "You haven't entered a correct positive number";

        private const int MinValue = 1;
        private const int MaxValue = 100;
        
        public static void Main()
        {

            int size = ReadInput();
            SquareMatrix matrix = null;

            do
            {
                try
                {
                    matrix = new SquareMatrix(size);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Logger.Log(ex.Message);
                    size = ReadInput();
                }
            }
            while (matrix == null);

            matrix.FillRotatingWalk();
            Console.WriteLine(matrix);
        }

        private static int ReadInput()
        {
            Logger.Log(EnterAPositiveNumber);
            string input = Console.ReadLine();
            int number = 0;

            while (!int.TryParse(input, out number) || MinValue > number || number > MaxValue)
            {
                Logger.Log(InvalidNumberErrorMessage);
                input = Console.ReadLine();
            }

            return number;
        }
    }
}

