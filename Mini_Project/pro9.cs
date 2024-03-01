using System;

public class Complex
{
    private double real;
    private double imaginary;

    // Parameterized constructor
    public Complex(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    // Method to overload the '+' operator
    public static Complex operator +(Complex c1, Complex c2)
    {
        double realSum = c1.real + c2.real;
        double imaginarySum = c1.imaginary + c2.imaginary;
        return new Complex(realSum, imaginarySum);
    }

    // Method to display the complex number
    public void Display()
    {
        Console.WriteLine("Result: " + real + " + " + imaginary + "i");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Complex Numbers:");
        Console.WriteLine("Description: Complex numbers consist of a real part and an imaginary part.");
        Console.WriteLine("Performing arithmetic operations on complex numbers involves addition, subtraction,");
        Console.WriteLine("multiplication, and division. Complex numbers are essential in engineering, physics,");
        Console.WriteLine("and various scientific disciplines.");

        Console.WriteLine("Enter the first complex number:");
        Console.Write("Real part: ");
        double real1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Imaginary part: ");
        double imaginary1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEnter the second complex number:");
        Console.Write("Real part: ");
        double real2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Imaginary part: ");
        double imaginary2 = Convert.ToDouble(Console.ReadLine());

        // Create Complex objects
        Complex complex1 = new Complex(real1, imaginary1);
        Complex complex2 = new Complex(real2, imaginary2);

        // Add two complex numbers
        Complex result = complex1 + complex2;

        // Display the result
        Console.WriteLine("\nSum of the complex numbers:");
        result.Display();

        Console.ReadLine(); // Keep the console window open
    }
}
