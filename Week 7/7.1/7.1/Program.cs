namespace _7._1
{
    internal class Program
    {
        static void Main(string[] args)
    
        {
       
            {
                int[] scores = { 64, 25, 12, 22, 11 };
                SelectionSort(scores);

                Console.WriteLine("Sorted scores:");
                foreach (int score in scores)
                {
                    Console.Write(score + " ");
                }
            }

            static void SelectionSort(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[j] < arr[minIndex])
                        {
                            minIndex = j;
                        }
                    }
                    // Swap arr[i] with arr[minIndex]
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

    }
}

