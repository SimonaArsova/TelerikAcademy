﻿using System;

namespace NumbersToN
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
