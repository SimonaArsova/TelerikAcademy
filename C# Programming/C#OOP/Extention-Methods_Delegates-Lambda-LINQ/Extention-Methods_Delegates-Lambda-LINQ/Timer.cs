using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Methods_Delegates_Lambda_LINQ
{
    //Problem 7
    delegate void PrintSomething(int seconds);
    public class Timer
    {
        public static void PrintTime(int seconds)
        {
            Console.WriteLine("{0} seconds passed.", seconds);
        }
    }
}
