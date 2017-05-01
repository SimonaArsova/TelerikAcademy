using System;

namespace Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            string instructions = Console.ReadLine();
            char digit;
            int value;

            for (int i = 0; i < instructions.Length; i++)
            {
                digit = instructions[i];
                if (!char.IsDigit(digit))
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                    break;
                }
                else 
                {
                    value = digit - '0';
                    if (value == 0)
                    {
                        Console.WriteLine("Too drunk to go on after {0}!", i);
                        break;
                    }
                    else if (value % 2 == 0)
                    {
                        i += value;
                        if (i > instructions.Length - 1)
                        {
                            Console.WriteLine("Fell off the dancefloor at {0}!", i);
                            break;
                        }
                        i--;
                    }
                    else if (value % 2 != 0)
                    {
                        i -= value;
                        if (i < 0)
                        {
                            Console.WriteLine("Fell off the dancefloor at {0}!", i);
                            break;
                        }
                        i--;
                    }
                    
                }
            }

        }
    }
}
