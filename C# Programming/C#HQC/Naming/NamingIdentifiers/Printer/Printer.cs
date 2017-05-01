namespace Printer
{
    using System;

    public class Printer
    {
        public static void Main()
        {
            Printer.BooleanPrinter printer = new Printer.BooleanPrinter();
            printer.PrintBoolVariableAsString(true);
        }

        public class BooleanPrinter
        {
            public void PrintBoolVariableAsString(bool value)
            {
                string valueAsString = value.ToString();
                Console.WriteLine(valueAsString);
            }
        }
    }
}
