using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Square square = new Square("blue", 10);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        
        Rectangle rectangle= new Rectangle("green", 5, 6);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("orange", 10);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}