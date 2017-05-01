using System;

namespace IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            char[] word = Console.ReadLine().ToCharArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i] == alphabet[j])
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}
