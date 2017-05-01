
namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    class Startup
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            //define variables
            int variableInt = 0;
            long variableLong = 0L;
            float variableFloat = 0.0F;
            double variableDouble = 0.0;
            decimal variableDecimal = 0.0M;

            Console.WriteLine("============Add============");
            stopwatch.Start();
            for (int i = 1; i <= 10000; i++)
            {
                stopwatch.Start();
                variableInt += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Int addition - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (long i = 1L; i <= 10000L; i++)
            {
                variableLong += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Long addition - " + stopwatch.Elapsed);
        
            stopwatch.Restart();
            for (float i = 0.0001F; i <= 1.0000F; i += 0.0001F)
            {
                variableFloat += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Float addition - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (double i = 0.0001; i <= 1.0000; i += 0.0001)
            {
                variableDouble += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Double addition - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (decimal i = 0.0001M; i <= 1.0000M; i += 0.0001M)
            {
                variableDecimal += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal addition - " + stopwatch.Elapsed + "\n");
            

            Console.WriteLine("=========Substract=========");
            stopwatch.Restart();
            for (int i = 10000; i > 0; i--)
            {
                variableInt -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Int substraction - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (long i = 10000L; i > 0L; i--)
            {
                variableLong -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Long substraction - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (float i = 1.0000F; i > 0.0F; i -= 0.0001F)
            {
                variableFloat -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Float substraction - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (double i = 1.0000; i > 0.0; i -= 0.0001)
            {
                variableDouble -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Double substraction - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (decimal i = 1.0000M; i > 0.0M; i -= 0.0001M)
            {
                variableDecimal -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal substraction - " + stopwatch.Elapsed + "\n");


            Console.WriteLine("=========Increment=========");
            stopwatch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                variableInt++;
            }
            stopwatch.Stop();
            Console.WriteLine("Int increment - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                variableLong++;
            }
            stopwatch.Stop();
            Console.WriteLine("Long increment - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                variableFloat++;
            }
            stopwatch.Stop();
            Console.WriteLine("Float increment - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                variableDouble++;
            }
            stopwatch.Stop();
            Console.WriteLine("Double increment - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                variableDecimal++;
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal increment - " + stopwatch.Elapsed + "\n");


            Console.WriteLine("==========Multiply==========");
            variableInt = 1;
            stopwatch.Restart();
            for (int i = 1; i < 10; i++)
            {
                variableInt *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Int multiply - " + stopwatch.Elapsed);

            variableLong = 1;
            stopwatch.Restart();
            for (long i = 1L; i < 10L; i++)
            {
                variableLong *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Long multiply - " + stopwatch.Elapsed);

            variableFloat = 1.0F;
            stopwatch.Restart();
            for (float i = 0.1F; i < 1.0F; i += 0.1F)
            {
                variableFloat *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Float multiply - " + stopwatch.Elapsed);

            variableDouble = 1.0;
            stopwatch.Restart();
            for (double i = 0.1; i < 1.0; i += 0.1)
            {
                variableDouble *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Double multiply - " + stopwatch.Elapsed);

            variableDecimal = 1.0M;
            stopwatch.Restart();
            for (decimal i = 0.1M; i < 1.0M; i += 0.1M)
            {
                variableDecimal *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal multiply - " + stopwatch.Elapsed + "\n");


            Console.WriteLine("===========Divide===========");
            stopwatch.Restart();
            for (int i = 1; i < 10; i++)
            {
                variableInt /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Int divide - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (long i = 1L; i < 10L; i++)
            {
                variableLong /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Long divide - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (float i = 0.1F; i < 1.0F; i += 0.1F)
            {
                variableFloat /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Float divide - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (double i = 0.1; i < 1.0; i += 0.1)
            {
                variableDouble /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Double divide - " + stopwatch.Elapsed);

            stopwatch.Restart();
            for (decimal i = 0.1M; i < 1.0M; i += 0.1M)
            {
                variableDecimal /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal divide - " + stopwatch.Elapsed);
        }
    }
}
