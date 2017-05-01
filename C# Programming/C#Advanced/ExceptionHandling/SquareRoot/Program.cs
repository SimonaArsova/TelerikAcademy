using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number > 0)
                {
                    Console.WriteLine("{0:F3}",Math.Sqrt(number));
                }
                else
                {
                    throw new FormatException();
                }
              
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
            
        }
    }
}
