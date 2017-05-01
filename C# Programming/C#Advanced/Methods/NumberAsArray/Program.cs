using System;
using System.Linq;
using System.Numerics;

namespace NumberAsArray
{
    class Program
    {
        //        static void Main(string[] args)
        //        {
        //            string line = Console.ReadLine();
        //            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //            Array.Reverse(firstArray);
        //            Array.Reverse(secondArray);
        //            BigInteger firstNumber = ArrayToNumber(firstArray);
        //            BigInteger secondNumber = ArrayToNumber(secondArray);

        //            SumNumbers(firstNumber, secondNumber);

        //        }

        //        static BigInteger ArrayToNumber(int[] array)
        //        {
        //            BigInteger number = 0;
        //            for (int i = 0; i < array.Length; i++)
        //            {
        //                number = number * 10 + array[i];
        //            }
        //            return number;
        //        }

        //        static void SumNumbers (BigInteger first, BigInteger second)
        //        {
        //            char[] result = (first + second).ToString().ToCharArray();
        //            Array.Reverse(result);
        //            Console.Write(result[0]);
        //            for (int i = 1; i < result.Length; i++) 
        //            {
        //                Console.Write(" {0}",result[i]);
        //            }
        //        }


        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstArrSize = input[0];
            int secondArrSize = input[1];
            int one = 0;
            int[] result = new int[Math.Max(firstArrSize, secondArrSize) + 1];
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < Math.Min(firstArrSize, secondArrSize); i++)
            {
                result[i] = (firstArray[i] + secondArray[i] + one) % 10;
                one = (firstArray[i] + secondArray[i] + one) / 10;
            }

            if (firstArrSize > secondArrSize)
            {
                for (int i = secondArrSize; i < firstArrSize; i++)
                {
                    result[i] = (firstArray[i] + one) % 10;
                    one = (firstArray[i] + one) / 10;
                }
            }
            else if (secondArrSize > firstArrSize)
            {
                for (int i = firstArrSize; i < secondArrSize; i++)
                {
                    result[i] = (secondArray[i] + one) % 10;
                    one = (secondArray[i] + one) / 10;
                }
            }

            result[Math.Max(firstArrSize, secondArrSize)] = one;
            int length = result.Length;
            for (int i = 0; i < length; i++)
            {
                if (i + 1 == length)
                {
                    if (result[i] == 0)
                    {
                        continue;
                    }
                }

                Console.Write(result[i] + " ");
            }

        }
    }
}
