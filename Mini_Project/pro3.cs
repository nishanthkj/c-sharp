using System;

class SubstringList
{
    static void Main()
    {
        Console.WriteLine("Substring of Strings:");
        Console.WriteLine("Description: Substrings are contiguous sequences of characters within a given string.");
        Console.WriteLine("Generating all possible substrings of a string involves extracting combinations of");
        Console.WriteLine("characters from different positions within the string. This process is crucial for tasks");
        Console.WriteLine("such as pattern matching and data analysis.");

        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        if (!ContainsNumber(inputString))
        {
            Console.WriteLine("All substrings of the given string:");
            ListAllSubstrings(inputString);
        }
        else
        {
            Console.WriteLine("Error: Please enter a non-numeric string.");
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
