using System;
namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const int START = 1;
            const int END = 100;
            ReadNumber(START, END);
        }

        static void ReadNumber(int start, int end)
        {
            int[] numbers = new int[12];
            numbers[0] = 1;
            numbers[11] = 100;
            
            try
            {
                bool isTrue = false;
                for (int i = 1; i < numbers.Length-1; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < numbers.Length-1; i++)
                {
                    if (numbers[i] < numbers[i + 1]) 
                    {
                        isTrue = true;
                    }
                    else
                    {
                        isTrue = false;
                        throw new ArgumentOutOfRangeException();
                    }
                }
                if (isTrue)
                {
                    Console.WriteLine(string.Join(" < ", numbers));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
