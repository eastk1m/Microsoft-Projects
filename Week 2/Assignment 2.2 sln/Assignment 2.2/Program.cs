
namespace Assignment_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("Select an option:");
                Console.WriteLine();
                Console.WriteLine("1. Calculate the area of a square");
                Console.WriteLine("2. Calculate the area of a circle");
                Console.WriteLine("3. Calculate the area of a rectangle");
                Console.Write("Enter your choice (1 or 2 or 3): ");

                string readResult = Console.ReadLine();

                Console.WriteLine();

                switch (readResult)
                {
                    case "1":
                        Console.WriteLine("You chose a square. Please enter the length of the side of the square: ");
                        double lengthOfSide = Convert.ToDouble(Console.ReadLine());
                        Square mySquare = new Square();
                        mySquare.CalculateArea(lengthOfSide);
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("You chose a circle. Please enter the radius of the circle: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle myCircle = new Circle();
                        myCircle.CalculateArea(radius);
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("You chose a rectangle. Please enter the length of the rectangle: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("You chose a rectangle. Please enter the width of the rectangle: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Rectangle myRectangle = new Rectangle();
                        myRectangle.CalculateArea(length * width);
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                while (true) ;
            }
    }


    public enum ColorValues { Red, Blue, Green }
     

    public class Shape

    { 

    {
        public string ShapeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public virtual void CalculateArea() => Console.WriteLine("This shape has an area.");
    }

    public class Square : Shape
    {

        public double LengthofSide { get; set; }

        public void CalculateArea(double LengthOfSide) => Console.WriteLine("The area of a square is: " + Math.Pow(LengthofSide, 2));
    }

    public class Circle : Shape

    {
        private double radius;

        public double Radius { get; set; }
        public void CalculateArea(double radius) => Console.WriteLine("The area of a circle is: " + Math.PI * Math.Pow(radius, 2));

    }

        public class Rectangle : Shape
        {  
            public double Width { get; set; } 

            public double Height { get; set; }

        public void CalculateArea(double width, double height) => Console.WriteLine("The area of a rectangle is: " + (Width * Height));
        
        }

    }

}

}
