using System;

namespace SubStringInText
{
    class Startup
    {
        static void Main()
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int position = -1;
            int counter = -1;

            do
            {
                position = text.IndexOf(pattern, position + 1);
                counter++;
            }
            while (position != -1);

            Console.WriteLine(counter);
        }
    }
}
