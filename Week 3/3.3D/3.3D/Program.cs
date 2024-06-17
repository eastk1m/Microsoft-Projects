namespace _3._3D
{
    internal class Program
    {
        private static readonly object i;

        static void Main(string[] args)
        {
            int[] numberArray = new int[] { 0, 2, 3, 1, 1, 3, 1, 1 };
            int target = 1;


            for (int i = 0; i < numberArray.Length; i++)
            if (numberArray [i] == target && (numberArray[i + 1]) == target)
                        { Console.WriteLine($"The first pair of {target}'s starts at index {i}");
                         break;


                         }

            Console.WriteLine($"Tested element {i} ");
        }
    }
}


