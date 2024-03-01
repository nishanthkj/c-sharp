using System;

class ArmstrongNumbersInRange
{
    static void Main()
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
