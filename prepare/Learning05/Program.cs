using System;

class Program
{
  static void Main(string[] args)
  //run some tests
  {
    List<Shape> shapes = new()
    {
      new Square("Red", 4),
      new Rectangle("Blue", 3, 6),
      new Circle("Green", 5)
    };

    foreach (Shape shape in shapes)
    {
      Console.WriteLine($"Color: {shape.Color}, Area: {shape.GetArea()}");
    }
  }
}
