using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Name:Nishanth K J");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("USN:4MH21CS065");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Faculty Name:Victor Ikechukwu Agughasi");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---                Select the Program from 1 to 12                ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 1  : Arithmetic Operations                          ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 2  : Armstrong Numbers                              ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 3  : Substring of Strings                           ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 4  : Divide By Zero Exception                       ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 5  : Pascal of a Triangle(Print Pattern)            ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 6  : Floyd,s Triangle                               ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 7  : Read and Copy a Text File                      ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 8  : Implementation of Stack Operations             ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 9  : Complex Numbers                                ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 10 : Polymorphism Concepts                          ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 11 : Abstract Class for Calculating the Perimeter   ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---   Program 12 : Interface for Resizable                        ---");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("---                         0 For  E X I T                        ---");
            Console.WriteLine("---------------------------------------------------------------------");


            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Program 1  : Arithmetic Operation");
                        pro11.pro1();

                        break;
                    case 2:
                        Console.WriteLine("Program 2  : Armstrong Numbers");
                        pro12.pro2();
                        break;
                    case 3:
                        Console.WriteLine("Program 3  : Substring of Strings");
                        pro13.pro3();
                        break;
                    case 4:
                        Console.WriteLine("Program 4  : Divide By Zero Exception");
                        pro14.pro4();
                        break;
                    case 5:
                        Console.WriteLine("Program 5  : Pascal of a Triangle(Print Pattern)");

                        pro15.pro5();
                        break;
                    case 6:
                        Console.WriteLine("Program 6  : Floyd,s Triangle");
                        pro16.pro6();
                        break;
                    case 7:
                        Console.WriteLine("Program 7  : Read and Copy a Text File");
                        pro17.pro7();
                        break;
                    case 8:
                        Console.WriteLine("Program 8  : Implementation of Stack Operations");
                        pro18.pro8();
                        break;
                    case 9:
                        Console.WriteLine("Program 9  : Complex Numbers");
                        pro19.pro9();
                        break;
                    case 10:
                        Console.WriteLine("Program 10 : Polymorphism Concepts");
                        pro110.Program10.pro10();
                        break;
                    case 11:
                        Console.WriteLine("Program 11 : Abstract Class for Calculating the Perimeter");
                        pro111.Program11.pro11();
                        break;
                    case 12:
                        Console.WriteLine("Program 12 : Interface for Resizable");
                        pro112.Program12.pro12();
                        break;
                    case 0:
                        Environment.Exit(1);
                        break;



                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }


            Console.ReadKey();
        }



    }
    public class pro11
    {
        public static void pro1()
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
    public class pro12
    {
        public static void pro2()
        {
            Console.WriteLine("Armstrong Numbers:");
            Console.WriteLine("Description: Armstrong numbers, also known as narcissistic numbers, are special numbers");
            Console.WriteLine("where the sum of each digit, each raised to the power of the number of digits in the number,");
            Console.WriteLine("equals the original number itself. Identifying Armstrong numbers involves analyzing the");
            Console.WriteLine("intrinsic relationship between a number and its individual digits.");

            // Get the range from the user
            Console.Write("Enter the start range: ");
            int startRange = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the end range: ");
            int endRange = Convert.ToInt32(Console.ReadLine());

            if (startRange <= endRange)
            {
                Console.WriteLine("Armstrong Numbers between " + startRange + " and " + endRange + ":");

                for (int number = startRange; number <= endRange; number++)
                {
                    if (IsArmstrongNumber(number))
                    {
                        Console.WriteLine(number);
                    }
                }

            }
            else
            {
                Console.WriteLine("Error: Start range should be less than or equal to end range.");
            }

            Console.ReadLine(); // Keep the console window open
        }
        // Function to check if a number is an Armstrong number
        static bool IsArmstrongNumber(int num)
        {
            int originalNum = num;
            int numDigits = CountDigits(num);
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, numDigits);
                num /= 10;
            }

            return sum == originalNum;
        }

        // Function to count the number of digits in a number
        static int CountDigits(int num)
        {
            int count = 0;

            while (num > 0)
            {
                num /= 10;
                count++;
            }

            return count;
        }
    }
    public class pro13
    {
        public static void pro3()
        {
            Console.WriteLine("Substring of Strings:");
            Console.WriteLine("Description: Substrings are contiguous sequences of characters within a given string.");
            Console.WriteLine("Generating all possible substrings of a string involves extracting combinations of");
            Console.WriteLine("characters from different positions within the string. This process is crucial for tasks");
            Console.WriteLine("such as pattern matching and data analysis.");

            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine().Trim();

            if (!ContainsNumber(inputString))
            {
                Console.WriteLine("All substrings of the given string:");
                ListAllSubstrings(inputString);
            }
            else
            {
                throw new ArgumentException("Error: Please enter a non-numeric string.");
            }

            Console.ReadLine(); // Keep the console window open
        }

        static void ListAllSubstrings(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int length = 1; length <= str.Length - i; length++)
                {
                    string substring = str.Substring(i, length);
                    Console.WriteLine(substring);
                }
            }
        }

        static bool ContainsNumber(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
    public class pro14
    {

        public static void pro4()

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
    public class pro15
    {
        public static void pro5()
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
    public class pro16
    {
        public static void pro6()
        {

            Console.WriteLine("Floyd's Triangle:");
            Console.WriteLine("Description: Floyd's Triangle is a right-angled triangular sequence of natural numbers.");
            Console.WriteLine("The pattern starts with 1 and increments successively in each row. Floyd's Triangle is");
            Console.WriteLine("often employed in programming exercises to create visually interesting patterns.");
            Console.Write("Enter the number of rows for Floyd's Triangle: ");
            int numRows = Convert.ToInt32(Console.ReadLine());

            int[][] floydsTriangle = GenerateFloydsTriangle(numRows);

            Console.WriteLine("Floyd's Triangle:");
            PrintFloydsTriangle(floydsTriangle);

            Console.ReadLine(); // Keep the console window open
        }

        static int[][] GenerateFloydsTriangle(int numRows)
        {
            int[][] triangle = new int[numRows][];

            int count = 1;

            for (int i = 0; i < numRows; i++)
            {
                triangle[i] = new int[i + 1];

                for (int j = 0; j <= i; j++)
                {
                    triangle[i][j] = count;
                    count++;
                }
            }

            return triangle;
        }

        static void PrintFloydsTriangle(int[][] triangle)
        {
            for (int i = 0; i < triangle.Length; i++)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    public class pro17
    {

        public static void pro7()
        {
            Console.WriteLine("Read and Copy a Text File:");
            Console.WriteLine("Description: Reading and copying the contents of a text file is a common file");
            Console.WriteLine("manipulation task. This involves opening a source file, reading its contents, and");
            Console.WriteLine("then creating or overwriting a target file with the same content. This operation is");
            Console.WriteLine("fundamental in data processing and file management.");

            Console.Write("Enter the path of the source text file: ");
            string sourceFilePath = Console.ReadLine();

            Console.Write("Enter the path of the destination text file: ");
            string destinationFilePath = Console.ReadLine();

            try
            {
                // Read the contents of the source file
                string fileContents = File.ReadAllText(sourceFilePath);

                // Write the contents to the destination file
                File.WriteAllText(destinationFilePath, fileContents);

                Console.WriteLine("File contents copied successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine(); // Keep the console window open
        }

    }
    public class pro18
    {

        public static void pro8()
        {
            Console.WriteLine("Implementation of Stack Operations:");
            Console.WriteLine("Description: Stacks are data structures that follow the Last In, First Out (LIFO)");
            Console.WriteLine("principle. Implementing stack operations involves defining methods for pushing");
            Console.WriteLine("(adding), popping (removing), peeking (viewing the top element), and displaying the");
            Console.WriteLine("elements of a stack. Stacks find applications in various algorithms and problem-solving");
            Console.WriteLine("scenarios.");

            StackImplementation stack = new StackImplementation();
            while (true)
            {
                Console.Clear();

                Console.WriteLine("\nStack MENU(size -- 10)");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. See the Top element.");
                Console.WriteLine("3. Remove top element.");
                Console.WriteLine("4. Display stack elements.");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter an Element : ");
                            stack.Push(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Top element is: {0}", stack.Peek());
                            break;
                        case 3:
                            Console.WriteLine("Element removed: {0}", stack.Pop());
                            break;
                        case 4:
                            stack.Display();
                            break;
                        case 5:
                            Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.ReadKey();
            }
        }


        public interface IStackADT
        {
            bool isEmpty();
            void Push(object element);
            object Pop();
            object Peek();
            void Display();
        }

        public class StackImplementation : IStackADT
        {
            private const int StackSize = 10;
            private int top;
            private readonly object[] items;

            public StackImplementation()
            {
                items = new object[StackSize];
                top = -1;
            }

            public bool isEmpty()
            {
                return top == -1;
            }

            public void Push(object element)
            {
                if (top == (StackSize - 1))
                {
                    Console.WriteLine("Stack is full!");
                }
                else
                {
                    items[++top] = element;
                    Console.WriteLine("Item pushed successfully!");
                }
            }

            public object Pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty!");
                    return "No elements";
                }
                else
                {
                    return items[top--];
                }
            }

            public object Peek()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty!");
                    return "No elements";
                }
                else
                {
                    return items[top];
                }
            }

            public void Display()
            {
                for (int i = top; i > -1; i--)
                {
                    Console.WriteLine("Item {0}: {1}", (i + 1), items[i]);
                }
            }
        }
    }
    public class pro19
    {
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
        public static void pro9()
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
    public class pro110
    {
        // Base class
        public class Shape
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
        public class Circle : Shape
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
        public class Triangle : Shape
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
        public class Square : Shape
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

        public class Program10
        {
            public static void pro10()
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
            public static void DrawAndErase(Shape shape)
            {
                shape.Draw();
                shape.Erase();
                Console.WriteLine(); // Add a newline for better readability
            }
        }

    }
    public class pro111
    {
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

        public class Program11
        {
            public static void pro11()
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


    }

    public class pro112
    {


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

        public class Program12
        {
            public static void pro12()
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

    }
}

