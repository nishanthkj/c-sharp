using System;

// Define the Resizable interface
public interface Resizable
{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}

// Implement the Resizable interface in the Rectangle class
public class Rectangle : Resizable
{
    private int width;
    private int height;

    // Constructor to initialize width and height
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    // Method to display the current dimensions of the rectangle
    public void DisplayDimensions()
    {
        Console.WriteLine("Rectangle Dimensions: Width = " + width + ", Height = " + height);
    }

    // Implement ResizeWidth method from the Resizable interface
    public void ResizeWidth(int newWidth)
    {
        width = newWidth;
        Console.WriteLine("Resized Width to " + width);
    }

    // Implement ResizeHeight method from the Resizable interface
    public void ResizeHeight(int newHeight)
    {
        height = newHeight;
        Console.WriteLine("Resized Height to " + height);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Interface for Resizable:");
        Console.WriteLine("Description: Interfaces define a contract that classes must adhere to. Implementing an");
        Console.WriteLine("interface for resizing rectangles involves specifying methods that a class must provide");
        Console.WriteLine("to enable resizing operations. This promotes code consistency and ensures that classes");
        Console.WriteLine("implementing the interface support resizing functionality.");
        // Prompt user for initial dimensions
        Console.Write("Enter initial width: ");
        int initialWidth = int.Parse(Console.ReadLine());

        Console.Write("Enter initial height: ");
        int initialHeight = int.Parse(Console.ReadLine());

        // Create an instance of Rectangle with user-provided dimensions
        Rectangle rectangle = new Rectangle(initialWidth, initialHeight);

        // Display the initial dimensions
        Console.WriteLine("\nInitial Dimensions:");
        rectangle.DisplayDimensions();

        // Prompt user for new dimensions
        Console.Write("\nEnter new width for resizing: ");
        int newWidth = int.Parse(Console.ReadLine());
        rectangle.ResizeWidth(newWidth);

        Console.Write("Enter new height for resizing: ");
        int newHeight = int.Parse(Console.ReadLine());
        rectangle.ResizeHeight(newHeight);

        // Display the updated dimensions
        Console.WriteLine("\nUpdated Dimensions:");
        rectangle.DisplayDimensions();

        Console.ReadLine(); // Keep the console window open
    }
}
