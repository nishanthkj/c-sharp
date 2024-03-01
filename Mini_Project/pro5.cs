using System;

class ExceptionDemo
{
    static void Main()
    {
        Console.WriteLine("Pascal's Triangle:");
        Console.WriteLine("Description: Pascal's Triangle is a mathematical construct where each number is the sum");
        Console.WriteLine("of the two numbers directly above it. The triangle is often represented as an array of");
        Console.WriteLine("binomial coefficients, finding applications in probability theory, algebra, and combinatorics.");


        // Division by Zero Exception
        Console.WriteLine("Division by Zero Exception:");
        try
        {
            int numerator = 10;
            int denominator = 0;
            int result = DivideNumbers(numerator, denominator);
            Console.WriteLine("Result of division: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine("Numerator: 10, Denominator: 0");
        }

        // Index Out of Range Exception
        Console.WriteLine("\nIndex Out of Range Exception:");
        try
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int index = 10; // Trying to access an element at an index that is out of range
            int value = GetElementAtIndex(numbers, index);
            Console.WriteLine("Value at index " + index + ": " + value);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.ReadLine(); // Keep the console window open
    }

    static int DivideNumbers(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return numerator / denominator;
    }

    static int GetElementAtIndex(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }
        return array[index];
    }
}
