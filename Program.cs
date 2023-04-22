using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //Print calculation output of square area and perimeter
        Square mySquare = new Square(5);
        double squarePerimeter = mySquare.Perimeter();
        double squareArea = mySquare.Area();
        Console.WriteLine("Square perimeter is {0}, square area is {1}.", squarePerimeter, squareArea);

        //Print calculation output of triangle area and perimeter
        Triangle myTriangle = new Triangle(5, 5, 10);
        double TrianglePerimeter = myTriangle.Perimeter();
        double TriangleArea = myTriangle.Area();
        Console.WriteLine("Triangle perimeter is {0}, triangle area is {1}.", TrianglePerimeter, TriangleArea);


        //Print calculation output of circle area and perimeter
        Circle myCircle = new Circle(10);
        double CirclePerimeter = myCircle.Perimeter();
        double CircleArea = myCircle.Area();
        Console.WriteLine("Circle perimeter is {0}, circle area is {1}.", CirclePerimeter, CircleArea);



    }
}
