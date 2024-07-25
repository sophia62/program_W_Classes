public abstract class Shape
{
  public string Color { get; set; }

  public Shape(string color)
  {
    Color = color;
  }

  public abstract double GetArea();
}

public class Square : Shape
{
  private double _side;

  public Square(string color, double side) : base(color)
  {
    _side = side;
  }

  public override double GetArea()
  {
    return _side * _side;
  }
}
//baby
public class Rectangle : Shape
{
  private double _length;
  private double _width;

  public Rectangle(string color, double length, double width) : base(color)
  {
    _length = length;
    _width = width;
  }

  public override double GetArea()
  {
    return _length * _width;
  }
}

//baby
public class Circle : Shape
{
  private double _radius;

  public Circle(string color, double radius) : base(color)
  {
    _radius = radius;
  }

  public override double GetArea()
  {
    return Math.PI * _radius * _radius;
  }
}
