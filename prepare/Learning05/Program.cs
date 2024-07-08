using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 1);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("yellow", 2, 3);
        shapes.Add(rectangle);

        Circle circle = new Circle("blue", 4);
        shapes.Add(circle);

        foreach (Shape shape in shapes)

        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}