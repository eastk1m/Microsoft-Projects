namespace _7._2B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static bool IsVowel(char c)
            {
                c = char.ToLower(c);
                return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
            }

            static string ReverseVowels(string s)
            {
                char[] charArray = s.ToCharArray();
                int i = 0, j = s.Length - 1;

                while (i < j)
                {
                    if (IsVowel(charArray[i]) && IsVowel(charArray[j]))
                    {
                        char temp = charArray[i];
                        charArray[i] = charArray[j];
                        charArray[j] = temp;
                        i++;
                        j--;
                    }
                    else if (IsVowel(charArray[i]))
                    {
                        j--;
                    }
                    else
                    {
                        i++;
                    }
                }

                return new string(charArray);
            }

            static void Main()
            {
                string input1 = "hello";
                string input2 = "avacado";
                string input3 = "intelligent";

                Console.WriteLine("Output for \"" + input1 + "\": " + ReverseVowels(input1));
                Console.WriteLine("Output for \"" + input2 + "\": " + ReverseVowels(input2));
                Console.WriteLine("Output for \"" + input3 + "\": " + ReverseVowels(input3));
            }
        }

    }
}

