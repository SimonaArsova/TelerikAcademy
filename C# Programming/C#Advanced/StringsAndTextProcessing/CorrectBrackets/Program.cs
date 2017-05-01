using System;
namespace CorrectBrackets
{
    class Startup
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            int openBracket = 0;
            int closeBracket = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openBracket++;
                }
                if (input[i] == ')')
                {
                    closeBracket++;
                }
            }
            bool isCorrect = openBracket == closeBracket;

            Console.WriteLine(isCorrect ? "Correct" : "Incorrect");
        }
    }
}