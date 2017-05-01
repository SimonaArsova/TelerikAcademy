using System;

namespace HiddenMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string hiddenMessage="";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;
                int index = int.Parse(input);
                int step = int.Parse(Console.ReadLine());
                string text = Console.ReadLine();
                if (index < 0) 
                {
                    index += text.Length;
                }
                for (; index < text.Length && index >= 0; index += step) 
                {
                    hiddenMessage += text[index];
                }
            }
            Console.WriteLine(hiddenMessage);
            
           
            }
        }
}
