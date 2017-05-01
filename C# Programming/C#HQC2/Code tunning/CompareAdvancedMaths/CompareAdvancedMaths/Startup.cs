
namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    class Startup
    {
        static void Main()
        {
            float resultFloat = 0.0F;
            double resultDouble = 0.0;
            decimal resultDecimal = 0.0M;

            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("=======Square root=======");

            stopwatch.Start();
            resultFloat = (float)Math.Sqrt(33333.33333f);
            stopwatch.Stop();
            Console.WriteLine("Float - " + stopwatch.Elapsed);

            stopwatch.Restart();
            resultDouble = Math.Sqrt(33333.33333);
            stopwatch.Stop();
            Console.WriteLine("Double - " + stopwatch.Elapsed);

            stopwatch.Restart();
            resultDecimal = (decimal)Math.Sqrt((double)33333.33333M);
            stopwatch.Stop();
            Console.WriteLine("Decimal - " + stopwatch.Elapsed + "\n");

            Console.WriteLine("========Natural logarithm=======");

            stopwatch.Restart();
            resultFloat = (float)Math.Log(33333.33333f, Math.E);
            stopwatch.Stop();
            Console.WriteLine("Float - " + stopwatch.Elapsed);

            stopwatch.Restart();
            resultDouble = Math.Log(33333.33333, Math.E);
            stopwatch.Stop();
            Console.WriteLine("Double - " + stopwatch.Elapsed);

            stopwatch.Restart();
            resultDecimal = (decimal)Math.Log((double)33333.33333M, Math.E);
            stopwatch.Stop();
            Console.WriteLine("Decimal - " + stopwatch.Elapsed + "\n");

            Console.WriteLine("=========Sinus diagnostics==========");

            stopwatch.Restart();
            resultFloat = (float)Math.Sin(33333.33333f);
            stopwatch.Stop();
            Console.WriteLine("Float - " + stopwatch.Elapsed);

            stopwatch.Restart();
            resultDouble = Math.Sin(33333.33333);
            stopwatch.Stop();
            Console.WriteLine("Double - " + stopwatch.Elapsed);

            stopwatch.Restart();
            resultDecimal = (decimal)Math.Sin((double)33333.33333M);
            stopwatch.Stop();
            Console.WriteLine("Decimal - " + stopwatch.Elapsed);
        }
    }
}
