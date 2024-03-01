using System;

// Abstract class
abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

// Circle class extending Shape
class Circle : Shape
{
    private readonly double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

// Triangle class extending Shape
class Triangle : Shape
{
    private readonly double side1;
    private readonly double side2;
    private readonly double side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override double CalculateArea()
    {
        // Heron's formula for the area of a triangle
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public override double CalculatePerimeter()
    {
        return side1 + side2 + side3;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Abstract Class for Calculating the Perimeter:");
        Console.WriteLine("Description: Abstract classes provide a blueprint for other classes. Creating an");
        Console.WriteLine("abstract class for calculating the perimeter of shapes involves defining methods that");
        Console.WriteLine("subclasses must implement. This promotes code organization, reusability, and ensures");
        Console.WriteLine("consistency in calculating perimeters across various shape types.");

        // Get user input for the dimensions of the shapes
        Console.Write("Enter the radius of the circle: ");
        double circleRadius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the first side of the triangle: ");
        double triangleSide1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second side of the triangle: ");
        double triangleSide2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third side of the triangle: ");
        double triangleSide3 = Convert.ToDouble(Console.ReadLine());

        // Create instances of Circle and Triangle
        Circle circle = new Circle(circleRadius);
        Triangle triangle = new Triangle(triangleSide1, triangleSide2, triangleSide3);

        // Display area and perimeter of Circle
        Console.WriteLine("Circle - Area: " + circle.CalculateArea() + ", Perimeter: " + circle.CalculatePerimeter());

        // Display area and perimeter of Triangle
        Console.WriteLine("Triangle - Area: " + triangle.CalculateArea() + ", Perimeter: " + triangle.CalculatePerimeter());

        Console.ReadLine(); // Keep the console window open
    }
}
