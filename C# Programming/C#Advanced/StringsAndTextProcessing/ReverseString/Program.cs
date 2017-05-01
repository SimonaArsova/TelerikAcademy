using System;
namespace ReverseString
{
    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            foreach (var i in input)
            {
                Console.Write(i);
            }
        }
    }
}
