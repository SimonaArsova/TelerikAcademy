using System;
using System.Numerics;
namespace PeshoCode
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int numberOfLines = int.Parse(Console.ReadLine());
            string text = "";
            for (int i = 0; i < numberOfLines; i++)
            {
                text += Console.ReadLine();
            }

            string substring = "";
            BigInteger index = (BigInteger)text.IndexOf(word);
            for (index = 0; index < (BigInteger)text.Length; index++)
            {
                if ((text.IndexOf(".") < text.IndexOf("?") && text.IndexOf("?") != -1) && text.IndexOf(".") != -1)
                {
                    substring = DotStatement(text, word);
                    break;
                }
                else if ((text.IndexOf(".") > text.IndexOf("?") && text.IndexOf(".") != -1) && text.IndexOf("?") != -1)
                {
                    substring = QuestionStatement(text, word);
                    break;
                }
                else
                {
                    if (text.IndexOf(".") != -1)
                    {
                        substring = DotStatement(text, word);
                        break;
                    }
                    else if(text.IndexOf("?")!=-1)
                    {
                        substring = QuestionStatement(text, word);
                    }
                }

            }
            
            BigInteger sum = SumASCIICodes(substring);
            
            Console.WriteLine(sum);
            
        }

        static string DotStatement(string text, string word)
        {
            string result = "";
            string[] splitResult = text.Split('.', '?');
            for (ulong i = 0; i < (ulong)splitResult.Length; i++)
            {
                if (splitResult[i].IndexOf(word) != -1)
                {
                    int sentenceWordIndex = splitResult[i].IndexOf(word);
                    result = splitResult[i].Substring(0, sentenceWordIndex);
                }
            }
            return result.ToUpper();
        }

        static string QuestionStatement(string text, string word)
        {
            string result = "";
            string[] splitResult = text.Split('.', '?');
            for (ulong i = 0; i < (ulong)splitResult.Length; i++)
            {
                if (splitResult[i].IndexOf(word) != -1)
                {
                    int sentenceWordIndex = splitResult[i].IndexOf(word);
                    result = splitResult[i].Substring(sentenceWordIndex + word.Length);
                }
            }

            return result.ToUpper();
        }

        static BigInteger SumASCIICodes(string substring)
        {
            BigInteger sum = 0;
            for (int i = 0; i < substring.Length; i++)
            {
                if(substring[i]!=' ')
                {
                    sum += substring[i];
                }
            }

                return sum;
        }
    }
}
