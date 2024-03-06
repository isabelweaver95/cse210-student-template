using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("red", 4);
        Rectangle rectangle = new Rectangle("blue", 4, 5);
        Circle circle = new Circle("yellow", 4);
        Rectangle rectangle1 = new Rectangle("green", 4, 5);
        Square square1 = new Square("purple", 4);
        Circle circle1 = new Circle("orange", 4);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(rectangle1);
        shapes.Add(square1);
        shapes.Add(circle1);

        foreach(Shape shape in shapes){
            Console.WriteLine("Color: \t " + shape.GetColor());
            Console.WriteLine($"Area: \t {shape.GetArea()}"); 
        }
    }
}