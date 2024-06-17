using System.ComponentModel.Design;
using System.Drawing;
using System.Security.Principal;
using System.Transactions;

namespace _1._3._1
{
    // area of a square, rectangle, triangle 

    internal class Program
    {
        private static string readResult;

        static void Main(string[] args)
        {

            do
            {

                Console.WriteLine("Please enter your choice from the menu;");
                Console.WriteLine("Enter T for Triangle");
                Console.WriteLine("Enter S for Square");
                Console.WriteLine("Enter R for Rectangle");
                Console.WriteLine();
                Console.WriteLine("Enter X to Exit program");

                string readResult = Console.ReadLine();

                switch (readResult)
                {
                    case "T":
                    case "t":
                        Console.WriteLine("Enter length of triangle");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter height of triangle");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of the triangle is" + AreaofTriangle(width, height));
                        Console.WriteLine();
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("Enter length of side of square");
                        double side = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of the square is" + AreaofSquare(side * side));
                        Console.WriteLine();
                        break;
                    case "R":
                    case "r":
                        Console.WriteLine("You want to Multiply");
                        break;

                    case "X":
                    case "x":
                        Console.WriteLine("You want to Multiply");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }
            while (readResult != "X" && readResult != "x");


            static double AreaofTriangle(double width, double height)
            {
                return (width * height) / 2;

                double result = width * height * .5;
                {
                    return result;

                    static double AreaofSquare(double side)
                    {
                        return side * side;






                    }
                }
            }
        }

        private static string AreaofSquare(double v)
        {
            throw new NotImplementedException();
        }
    }
}

    
