using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateSymbols("ivan", "^([A-Z])", "Invalid name");

        }

        public static void ValidateSymbols(string value, string pattern, string message)
        {
            var regex = new Regex(pattern);

            if (!regex.IsMatch(value))
            {
                throw new ArgumentException(message);
            }
        }
    }
}
