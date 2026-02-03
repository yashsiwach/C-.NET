using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] shapes = { "C 10", "R 5 4", "T 6 3" };
        Console.WriteLine(TotalArea(shapes));
    }

    // Summary: Computes total area of shapes using abstraction and interface.
    static double TotalArea(string[] shapes)
    {
        double total = 0;

        foreach (var s in shapes)
            total += ShapeFactory.Create(s)?.Area() ?? 0;

        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }
}

interface IArea
{
    double Area();
}

abstract class Shape : IArea
{
    public abstract double Area();
}

class Circle : Shape
{
    double r;
    public Circle(double r) { this.r = r; }
    public override double Area() => Math.PI * r * r;
}

class Rectangle : Shape
{
    double w, h;
    public Rectangle(double w, double h) { this.w = w; this.h = h; }
    public override double Area() => w * h;
}

class Triangle : Shape
{
    double b, h;
    public Triangle(double b, double h) { this.b = b; this.h = h; }
    public override double Area() => 0.5 * b * h;
}

static class ShapeFactory
{
    public static Shape Create(string s)
    {
        var p = s.Split(' ');
        return p[0] switch
        {
            "C" => new Circle(double.Parse(p[1])),
            "R" => new Rectangle(double.Parse(p[1]), double.Parse(p[2])),
            "T" => new Triangle(double.Parse(p[1]), double.Parse(p[2])),
            _ => null
        };
    }
}
