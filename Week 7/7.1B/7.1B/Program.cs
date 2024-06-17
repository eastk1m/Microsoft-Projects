namespace _7._1B
{
    internal class Program
    {
        static void Main(string[] args)
      
        {
            static void Main()
            {
                string word1 = "abc";
                string word2 = "pqr";
                string merged = MergeStrings(word1, word2);

                Console.WriteLine("Merged string: " + merged);
            }

            static string MergeStrings(string word1, string word2)
            {
                int len1 = word1.Length;
                int len2 = word2.Length;
                int maxLength = Math.Max(len1, len2);

                char[] merged = new char[maxLength * 2];
                int index = 0;

                for (int i = 0; i < maxLength; i++)
                {
                    if (i < len1)
                        merged[index++] = word1[i];

                    if (i < len2)
                        merged[index++] = word2[i];
                }

                return new string(merged);
            }
        }

    }
}
