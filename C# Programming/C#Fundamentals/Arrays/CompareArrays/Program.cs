using System;
namespace CompareArrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];
            bool isEqual = true;
            for (int i = 0; i < n; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
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
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
