namespace MethodPrintStatistics
{
    using System;

    public class Printer
    {
        public void PrintStatistics(double[] arr, int count)
        {
            this.FindMaxElement(arr, count);
            this.FindMinElement(arr, count);
            this.CalculateAvg(arr, count);
        }

        private void FindMaxElement(double[] arr, int count)
        {
            double max = 0;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("Max: " + max);
        }

        private void FindMinElement(double[] arr, int count)
        {
            double min = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Min: " + min);
        }

        private void CalculateAvg(double[] arr, int count)
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Avg: " + (sum / count));
        }
    }
}
