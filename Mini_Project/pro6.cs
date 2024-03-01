using System;

class FloydsTriangle
{
    static void Main()
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
