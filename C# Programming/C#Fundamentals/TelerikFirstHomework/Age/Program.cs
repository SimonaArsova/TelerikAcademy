using System;
using System.Globalization;

namespace Age
{
    class Program
    {
        static void Main()
        {
                DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", CultureInfo.InvariantCulture); ;
                TimeSpan age = DateTime.Now - birthDate;
                Console.WriteLine((int)(age.Days / 365.25));
                Console.WriteLine((int)(age.Days / 365.25)+10);
        }
    }
}
