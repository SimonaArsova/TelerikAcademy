﻿using System;

namespace Circle
{
    class Program
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
        }
    }
}
