using System;

internal class Program
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] leftProducts = new int[n];
        int[] rightProducts = new int[n];
        int[] result = new int[n];

        // Compute left products
        leftProducts[0] = 1;
        for (int i = 1; i < n; i++)
        {
            leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
        }

        // Compute right products
        rightProducts[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
        {
            rightProducts[i] = rightProducts[i + 1] * nums[i + 1];
        }

        // Compute final result
        for (int i = 0; i < n; i++)
        {
            result[i] = leftProducts[i] * rightProducts[i];
        }

        return result;
    }

    static void Main()
    {
        int[] nums = { 1, 2, 3, 4 };
        int[] result = ProductExceptSelf(nums);

        Console.WriteLine("Result:");
        foreach (int val in result)
        {
            Console.Write(val + " ");
        }
    }
}
