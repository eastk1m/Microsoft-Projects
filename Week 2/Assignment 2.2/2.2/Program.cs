using System.Drawing;
using System.Xml.Linq;

namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)



    class Shape 

    { 
    def __init__(self, shape_id, name, color):
        self.shape_id = shape_id
    self.name = name
        self.color = color

    def calculate_area(self):
        pass  # Placeholder method, to be overridden by subclasses


class Circle(Shape) :
    def __init__(self, shape_id, name, color, radius):
        super().__init__(shape_id, name, color)
        self.radius = radius

    def calculate_area(self) :
        return 3.14 * self.radius** 2


class Square(Shape) :
    def __init__(self, shape_id, name, color, side):
        super().__init__(shape_id, name, color)
        self.side = side

    def calculate_area(self) :
        return self.side** 2


def main():
    shape_id = int (input("Enter shape ID: "))
    name = input("Enter shape name: ")
    color = input("Enter shape color: ")

    shape_type = input("Select shape (circle/square): ").lower()
    if shape_type == "circle":
        radius = float (input("Enter circle radius: "))
        shape = Circle(shape_id, name, color, radius)
    elif shape_type == "square":
        side = float (input("Enter square side length: "))
        shape = Square(shape_id, name, color, side)
    else:
        print("Invalid shape type. Please choose 'circle' or 'square'.")
        return

    area = shape.calculate_area()
    print(f"Area of {shape.name} ({shape_type}): {area:.2f}")


if __name__ == "__main__":
    main()
    }

}