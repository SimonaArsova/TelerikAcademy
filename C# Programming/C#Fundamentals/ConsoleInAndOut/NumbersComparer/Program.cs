using System;
namespace NumbersComparer
{
    class Program
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(firstNumber > secondNumber ? firstNumber : secondNumber);
        }
    }
}
