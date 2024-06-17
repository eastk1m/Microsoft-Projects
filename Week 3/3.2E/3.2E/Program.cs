namespace _3._2E
{
    using System;

    class Program
    {
        static int Search(int[] arr, int item)
        {
            int index = Array.IndexOf(arr, item);
            return index != -1 ? index : -1;
        }

        static void Main()
        {
            int[] arr1 = { 1, 5, 3 };
            int[] arr2 = { 9, 8, 3 };
            int[] arr3 = { 1, 2, 3 };

            Console.WriteLine($"Index of 5 in arr1: {Search(arr1, 5)}");
            Console.WriteLine($"Index of 3 in arr2: {Search(arr2, 3)}");
            Console.WriteLine($"Index of 4 in arr3: {Search(arr3, 4)}");
        }
    }

}
