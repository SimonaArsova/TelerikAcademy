using System;
namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int middle = 0;
            int first = 0;
            int last = n - 1;
            bool isFound = false;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int x = int.Parse(Console.ReadLine());

            Array.Sort(arr);
            while (first <= last && !isFound)
            {
                middle = (first + last) / 2;
                if (x == arr[middle])
                {
                    isFound = true;
                    Console.WriteLine(middle);
                    break;
                }
                else if (x > arr[middle])
                {
                    first = middle + 1;
                }
                else
                {
                    last = middle - 1;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("-1");
            }
            
        }
    }
}
