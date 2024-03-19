using System.Formats.Asn1;

namespace Triangles;
class Program
{
    static void Main(string[] args)
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");

        // Insert your solution here
        // Define variables
        string sidePrompt = "Enter the sides of the triangle, separated by commas:";
        string invalidMsg = "Invalid input. There must be 1, 2 or 3 sides.";
        string[] sideString = new string[0];

        // Prompt for sides of triangle
        Console.WriteLine(sidePrompt);
        string userInput = Console.ReadLine();

        // Split into array and parse to double
        if (userInput.Trim().Length != 0)
        {
            sideString = userInput.Split(',');
        }
        double[] sides = new double[sideString.Length];
        for (int i = 0; i < sideString.Length; i++)
        {
            sides[i] = double.Parse(sideString[i]);
        }

        // Check side count and create triangle
        Triangle triangle;
        switch (sides.Length)
        {
            case 1: triangle = new Triangle(sides[0]); break;
            case 2: triangle = new Triangle(sides[0], sides[1]); break;
            case 3: triangle = new Triangle(sides[0], sides[1], sides[2]); break;
            default:
                {
                    Console.WriteLine(invalidMsg);
                    triangle = new Triangle(-1); break;
                }
        }
        Console.WriteLine($"The triangle is of type {triangle.GetType()} and has an area of {triangle.GetArea()}.");

        // Keep the following line intact
        Console.WriteLine("===========================");
    }
}