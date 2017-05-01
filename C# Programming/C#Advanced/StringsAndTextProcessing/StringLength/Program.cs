using System;
using System.Collections.Generic;
using System.Linq;

namespace StringLength
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> text = input.Select(c => c.ToString()).ToList();

            while (text.Count < 20)
            {
                text.Add("*");
            }
            foreach (var t in text)
            {
                Console.Write(t);
            }
        }
    }
}
