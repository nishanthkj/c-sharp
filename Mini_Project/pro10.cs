using System;

// Base class
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }

    public virtual void Erase()
    {
        Console.WriteLine("Erasing a shape");
    }
}

// Derived class: Circle
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    public override void Erase()
    {
        Console.WriteLine("Erasing a circle");
    }
}

// Derived class: Triangle
class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }

    public override void Erase()
    {
        Console.WriteLine("Erasing a triangle");
    }
}

// Derived class: Square
class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }

    public override void Erase()
    {
        Console.WriteLine("Erasing a square");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Polymorphism Concepts:");
        Console.WriteLine("Description: Polymorphism is a programming concept that allows objects of different");
        Console.WriteLine("types to be treated as objects of a common type. Inheritance and interfaces facilitate");
        Console.WriteLine("polymorphism, enabling code flexibility and reusability. Demonstrating polymorphism");
        Console.WriteLine("using shapes showcases how a unified interface can be used for different geometric");
        Console.WriteLine("entities.");
        // Creating instances of each shape
        Shape circle = new Circle();
        Shape triangle = new Triangle();
        Shape square = new Square();

        // Demonstrating polymorphism
        Console.WriteLine("Using polymorphism:");

        Console.WriteLine("\nDrawing and erasing a circle:");
        DrawAndErase(circle);

        Console.WriteLine("\nDrawing and erasing a triangle:");
        DrawAndErase(triangle);

        Console.WriteLine("\nDrawing and erasing a square:");
        DrawAndErase(square);

        Console.ReadLine(); // Keep the console window open
    }

    // Polymorphic method
    static void DrawAndErase(Shape shape)
    {
        shape.Draw();
        shape.Erase();
        Console.WriteLine(); // Add a newline for better readability
    }
}
