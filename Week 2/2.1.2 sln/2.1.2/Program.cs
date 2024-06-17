using System.ComponentModel;

namespace _2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class SimpleMath
    {
        static public int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        static public decimal Add(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }

        static public float Multiply(float num1, float num2)
        {
            return (float)num1 * num2;

        }

        static public float Multiply(float num1, float num2, float num3)
        { return (float)num1 * num2* num3; }

                }
    
    }



