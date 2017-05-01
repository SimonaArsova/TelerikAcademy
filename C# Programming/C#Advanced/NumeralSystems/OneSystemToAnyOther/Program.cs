using System;
using System.Collections.Generic;

namespace OneSystemToAnyOther
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstBase = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            int secondBase = int.Parse(Console.ReadLine());
            ulong decimalNumber = ToDecimal(number, firstBase);
            Console.WriteLine(DecimalTo(decimalNumber, secondBase));
        }

        static ulong ToDecimal(string number, int firstBase)
        {
            ulong result = 0;
            foreach (char digit in number)
            {
                if (char.IsDigit(digit))
                {
                    result = result * (ulong)firstBase + digit - '0';
                }
                else
                {
                    result = result * (ulong)firstBase + (ulong)(digit - 'A' + 10);
                }

            }
            return result;
        }

        static string DecimalTo(ulong decNumber, int secondBase)
        {
            string result = "";
            ulong digit = 0;

            if (decNumber == 0)
            {
                result = "0";
            }
            else
            {
                while (decNumber != 0)
                {
                    digit = decNumber % (ulong)secondBase;
                    decNumber = decNumber / (ulong)secondBase;
                    if (digit > 9)
                    {
                        char letter = (char)((digit - 9 - 1) + 'A');
                        result = (letter.ToString()) + result;
                    }
                    else
                    {
                        result = digit + result;
                    }
                }
            }
            return result;
        }

        //static List<string> DecimalTo(ulong decNumber, int finalBase)
        //{
        //    List<string> anySystem = new List<string>();
        //    ulong remainder = 0;
        //    while (decNumber > 0)
        //    {
        //        if (decNumber % (ulong)finalBase == 0)
        //        {
        //            anySystem.Add("0");
        //        }
        //        if (decNumber % (ulong)finalBase != 0)
        //        {
        //            remainder = decNumber % (ulong)finalBase;

        //            switch (remainder.ToString())
        //            {
        //                case "10":
        //                    anySystem.Add("A");
        //                    break;
        //                case "11":
        //                    anySystem.Add("B");
        //                    break;
        //                case "12":
        //                    anySystem.Add("C");
        //                    break;
        //                case "13":
        //                    anySystem.Add("D");
        //                    break;
        //                case "14":
        //                    anySystem.Add("E");
        //                    break;
        //                case "15":
        //                    anySystem.Add("F");
        //                    break;
        //                default:
        //                    anySystem.Add(remainder.ToString());
        //                    break;
        //            }
        //        }
        //        decNumber /= (ulong)finalBase;
        //    }
        //    anySystem.Reverse();
        //    return anySystem;
        //}

    }
}
