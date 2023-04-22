using System;

public abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
}

public class Square : Shape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public override double Area()
    {
        return side * side;
    }

    public override double Perimeter()
    {
        return 4 * side;
    }
}

public class Triangle : Shape
{
    private double side1, side2, side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override double Area()
    {
        double p = (side1 + side2 + side3) / 2;
        return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
    }

    public override double Perimeter()
    {
        return side1 + side2 + side3;
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}


