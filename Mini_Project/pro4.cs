using System;

class ExceptionDemo
{
    static void Main()

    {

        Console.WriteLine("Divide By Zero Exception:");
        Console.WriteLine("Description: Handling DivideByZeroException in C# is essential to prevent runtime errors");
        Console.WriteLine("when attempting to divide a number by zero. This exception is raised when a program");
        Console.WriteLine("encounters an attempt to perform division where the divisor is zero. Implementing proper");
        Console.WriteLine("exception handling mechanisms ensures robustness and stability in the program.");
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
