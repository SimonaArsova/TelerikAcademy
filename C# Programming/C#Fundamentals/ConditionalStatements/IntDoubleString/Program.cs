﻿using System;
namespace IntDoubleString
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string value = Console.ReadLine();
            switch (type)
            {
                case "integer":
                    Console.WriteLine(int.Parse(value)+1);
                    break;
                case "real":
                    Console.WriteLine("{0:0.00}", double.Parse(value)+1.0);
                    break;
                case "text":
                    Console.WriteLine(value+"*");
                    break;
            }
        }
    }
}
