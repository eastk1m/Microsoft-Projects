namespace _7._2C
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            static bool IsAnagram(string s, string t)
            {
                // Convert both strings to character arrays
                char[] sChars = s.ToCharArray();
                char[] tChars = t.ToCharArray();

                // Sort the character arrays
                Array.Sort(sChars);
                Array.Sort(tChars);

                // Compare the sorted arrays
                return new string(sChars) == new string(tChars);
            }

            static void Main()
            {
                string s1 = "anagram";
                string t1 = "nagaram";
                string s2 = "rat";
                string t2 = "car";

                Console.WriteLine(IsAnagram(s1, t1)); // Output: True
                Console.WriteLine(IsAnagram(s2, t2)); // Output: False
            }
        }

    }
}

