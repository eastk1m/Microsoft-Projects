namespace _6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void MoveZerosToEnd(int[] nums)
            {
                int j = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        // Swap non-zero element with the pivot (0)
                        int temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                        j++;
                    }
                }
            }

        }
    }
}
