using System;
using System.Text.RegularExpressions;

namespace ReplaceTags
{
    class Startup
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex r = new Regex(@"(<\s*a\s*href\s*=)\s*""(.*?)""\s*>(.*?)<\s*/\s*a\s*>");
            string output = r.Replace(input, m => "[" + m.Groups[3] + "](" + m.Groups[2] + ")");

            Console.WriteLine(output);
        }
    }
}