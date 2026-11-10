using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Orange", 10);
        Rectangle rect = new Rectangle("Blue", 10, 12);
        Circle circle = new Circle("Pink", 5);
        shapes.AddRange([square, rect, circle]);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}