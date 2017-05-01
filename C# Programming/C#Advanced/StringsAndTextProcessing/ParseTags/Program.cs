using System;
using System.Text.RegularExpressions;

namespace ParseTags
{
    class Program
    {
        static void Main()
        {
            string textSample = Console.ReadLine();
            string pattern = "<upcase>(.*?)</upcase>";
            Console.WriteLine(Regex.Replace(textSample, pattern, m => m.Groups[1].ToString().ToUpper(), RegexOptions.Singleline));
        }
    }
}
