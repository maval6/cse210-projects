using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();

        // Add different shapes
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 3));
        shapes.Add(new Circle("Green", 2.5));

        // Iterate and display shape properties
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}
