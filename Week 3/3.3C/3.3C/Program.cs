// namespace _3._3C 
using System;

class Program
{
    static bool IsLeapYear(int year)
    {
        return (year % 400 == 0) || ((year % 100 != 0) && (year % 4 == 0));
    }

    static void Main()
    {
        int year = 2016;
        Console.WriteLine(IsLeapYear(year)); // Output: True

        year = 2018;
        Console.WriteLine(IsLeapYear(year)); // Output: False
    }
}
