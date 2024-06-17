using System;
using System.Text;

class Program
{
    static string GetEvenNumbers()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 2; i < 100; i += 2)
        {
            result.Append(i);
            if (i < 98)
                result.Append(", ");
        }
        return result.ToString();
    }

    static void Main()
    {
        string evenNumbers = GetEvenNumbers();
        Console.WriteLine($"Even numbers between 0 and 100: {evenNumbers}");
    }
}
