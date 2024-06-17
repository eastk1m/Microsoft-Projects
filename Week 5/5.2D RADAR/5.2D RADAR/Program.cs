namespace _5._2D_RADAR
{
    using System;

    public class Program
    {
        // Method to check if a string is a palindrome using recursion
        public static bool IsPalindrome(string text)
        {
            // Base case: If the length of the text is 0 or 1, it's a palindrome
            if (text.Length <= 1)
                return true;
            else
            {
                // Check if the first and last characters are equal
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    // Recursive call: Check the substring without the first and last characters
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }

        public static void Main()
        {
            Console.Write("Enter a string to check Palindrome: ");
            string inputString = Console.ReadLine();

            if (IsPalindrome(inputString))
                Console.WriteLine($"{inputString} is a Palindrome.");
            else
                Console.WriteLine($"{inputString} is not a Palindrome.");

            // Wait for user input before closing the console
            Console.ReadKey();
        }
    }
}