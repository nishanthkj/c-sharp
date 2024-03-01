using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Arithmetic Operations:");
        Console.WriteLine(" This task involves creating a program that performs fundamental");
        Console.WriteLine("arithmetic operations. These operations typically include addition, subtraction,");
        Console.WriteLine("multiplication, division, exponentiation (raising a number to a power), and finding");
        Console.WriteLine("the square root of a number. The user may input two numbers, and the program would");
        Console.WriteLine("compute and display the results of these operations.");



        Console.WriteLine("Simple Arithmetic Calculator");
        Console.WriteLine("Supported operations: +, -, *, /, %");

        // Read operator from the user
        Console.Write("Enter operator: ");
        char operation = Convert.ToChar(Console.ReadLine());

        // Read operands from the user
        Console.Write("Enter first operand: ");
        float operand1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter second operand: ");
        float operand2 = Convert.ToSingle(Console.ReadLine());

        float result = 0;

        // Perform the corresponding operation based on the operator
        switch (operation)
        {
            case '+':
                result = operand1 + operand2;
                break;
            case '-':
                result = operand1 - operand2;
                break;
            case '*':
                result = operand1 * operand2;
                break;
            case '/':
                if (operand2 != 0)
                    result = operand1 / operand2;
                else
                    Console.WriteLine("Error: Division by zero is not allowed.");
                break;
            case '%':
                if (operand2 != 0)
                    result = operand1 % operand2;
                else
                    Console.WriteLine("Error: Modulo by zero is not allowed.");
                break;
            default:
                Console.WriteLine("Error: Invalid operator entered.");
                break;
        }

        // Display the result
        Console.WriteLine("Result: {result}", result);

        Console.ReadLine(); // Keep the console window open
    }
}
