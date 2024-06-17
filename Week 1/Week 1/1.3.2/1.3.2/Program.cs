namespace _1._3._2

// C# to read n number of values in an array and display it in reverse order.
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] array = {1, 2, 3 };
            int n = array.Length;
            int temp = 0;
     
            for (int i = 0; i < (n/2); i++)
            {
              
                temp = array[i]; 
                array[i] = array[n - i - 1];
                array[(n - 1) - i] = temp;

            }


            foreach (int i in array)

            {
                Console.WriteLine(i);
            }




        }
    }
}
