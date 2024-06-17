namespace _6._2B__WB_
{
    internal class Program
    {
        static void Main(string[] args)
        { }
        private static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] output = new int[n];

            // Compute the prefix product from the front
            int carry = 1;
            for (int i = 0; i < n; i++)
            {
                output[i] = carry;
                carry *= nums[i];
            }

            // Reset the carry for the suffix product from the back
            carry = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                output[i] *= carry;
                carry *= nums[i];
            }

            return output;
        }
    }
}
