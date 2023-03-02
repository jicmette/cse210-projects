using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> listShapes = new List<Shape>();

        Square _square = new Square("Orange", 3);
        listShapes.Add(_square);

        Rectangle _rectangle = new Rectangle("Green", 10, 5);
        listShapes.Add(_rectangle);

        Circle _circle = new Circle("Blue", 8);
        listShapes.Add(_circle);

        foreach (Shape shape in listShapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}