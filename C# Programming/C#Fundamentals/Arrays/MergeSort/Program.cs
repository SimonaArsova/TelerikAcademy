using System;

public class MergeSort
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
 
        for (int iteration = 1; iteration < arr.Length; iteration *= 2)
        {
            int[] result = new int[arr.Length];
            
            for (int leftStart = 0; leftStart < arr.Length; leftStart += 2 * iteration)
            {
                int rightStart = Math.Min(leftStart + iteration, arr.Length);
                int rightEnd = Math.Min(leftStart + (2 * iteration), arr.Length);
                MergeSortedPartsOfArray(arr, leftStart, rightStart, rightEnd, result);
            }
            arr = result;
        }
        Console.WriteLine(string.Join("\n", arr));
    }

    private static void MergeSortedPartsOfArray(
        int[] arr1,
        int leftStart,
        int rightStart,
        int rightEnd,
        int[] result)
    {
        int resultIndex;
        int leftEnd = rightStart - 1;

        for (resultIndex = leftStart; resultIndex < rightEnd; resultIndex++)
        {
            if (leftStart <= leftEnd &&
                (rightStart >= rightEnd || arr1[leftStart] <= arr1[rightStart]))
            {
                result[resultIndex] = arr1[leftStart];
                leftStart++;
            }
            else
            {
                result[resultIndex] = arr1[rightStart];
                rightStart++;
            }
        }
    }
}