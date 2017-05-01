using System;
namespace CompareCharArrays
{
    class Program
    {
        static void Main()
        {
            char[] firstWord = Console.ReadLine().ToCharArray();
            char[] secondWord = Console.ReadLine().ToCharArray();
            bool isEqual = true;

            int minLength = Math.Min(firstWord.Length, secondWord.Length);
            
                for (int i = 0; i < minLength; i++)
                {
                    if (firstWord[i] != secondWord[i] && firstWord[i] < secondWord[i])
                    {
                        Console.WriteLine("<");
                        isEqual = false;
                        break;
                    }
                    else if (firstWord[i] != secondWord[i] && firstWord[i] > secondWord[i])
                    {
                        Console.WriteLine(">");
                        isEqual = false;
                        break;
                    }
                    else
                    {
                        isEqual = true;
                    }
                }

            if (isEqual)
            {
                if (firstWord.Length == secondWord.Length)
                {
                    Console.WriteLine("=");
                }
                else
                {
                    Console.WriteLine(firstWord.Length > secondWord.Length ? ">" : "<");
                }
            }
        }
    }
}
