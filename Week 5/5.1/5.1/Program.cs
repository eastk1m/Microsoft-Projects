using System;

class Program
{
    static bool IsPalindrome(int x)
    {
        string numString = x.ToString();
        int length = numString.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numString[i] != numString[length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it's a palindrome: ");
        int input = int.Parse(Console.ReadLine());

        bool isPalindromic = IsPalindrome(input);

        Console.WriteLine($"Is {input} a palindrome? {isPalindromic}");
    }
}
