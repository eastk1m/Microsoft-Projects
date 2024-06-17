namespace _5._3A
{
    using System;

    public class FlowerbedPlanting
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    int left = (i > 0) ? flowerbed[i - 1] : 0;
                    int right = (i < flowerbed.Length - 1) ? flowerbed[i + 1] : 0;
                    if (left == 0 && right == 0)
                    {
                        flowerbed[i] = 1;
                        count++;
                        n--;
                    }
                }
            }
            return n <= count;
        }

        public static void Main(string[] args)
        {
            // Example usage:
            int[] flowerbed1 = { 1, 0, 0, 0, 1 };
            int n1 = 1;
            Console.WriteLine(CanPlaceFlowers(flowerbed1, n1));  // Output: True

            int[] flowerbed2 = { 1, 0, 0, 0, 1 };
            int n2 = 2;
            Console.WriteLine(CanPlaceFlowers(flowerbed2, n2));  // Output: False
        }
    }

}
