namespace _1._4
{
    internal class Program
    {
        static void Main(string[] args)

        {
           Point point1 = new Point();
           Point point2 = new Point();

            if (point1.x == point2.x)
            {
                Console.WriteLine("Points are on the same axis");
            }
            else

            {
                Console.WriteLine("Point not on the same axis");

            }


        }
        struct Point
        {
           public double x;
           public double y;

        }



            }
}
}
