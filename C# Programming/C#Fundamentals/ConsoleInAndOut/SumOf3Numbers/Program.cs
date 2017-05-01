using System;

namespace SumOf3Numbers
{
    class Program
    {
        static void Main()
        {
            float firstNumber = float.Parse(Console.ReadLine());
            float secondNumber = float.Parse(Console.ReadLine());
            float thirdNumber = float.Parse(Console.ReadLine());

            Console.WriteLine(firstNumber+secondNumber+thirdNumber);
        }
    }
}
