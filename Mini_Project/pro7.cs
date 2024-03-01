using System;
using System.IO;

class FileCopy
{
    static void Main()
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
