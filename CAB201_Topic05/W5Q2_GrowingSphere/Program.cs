using System.Collections.Generic;
using System.Drawing;

namespace GrowingSphere;
class Program
{
    static void Main(string[] args)
    {
        // Keep the following lines intact
        Console.WriteLine("===========================");
        Point sphereCentre, collisionPoint;
        Sphere sphere;
        List<double> growthRates;
        int secondsElapsed = 0;

        // Insert your solution here
        // 1. Read the sphere centre's position using the GetPoint() method, and the prompt:
        // "Enter the position of the sphere centre X, Y, Z:"
        sphereCentre = ReadPoint("Enter the position of the sphere centre X, Y, Z:");

        // 2. Read the sphere's radius (positive) from the console using the prompt:
        // "Enter the sphere's radius:"
        // You can use the ReadPositiveDouble() method below to help you with this
        double radius = ReadPositiveDouble("Enter the sphere's radius:");

        // 3. Read and parse the sphere's growth rates from the console using the prompt:
        // "Enter the sphere's growth rates, separated by commas:"
        // You may want to implement the ParsePositiveDoubles() method below to help you with this
        Console.WriteLine("Enter the sphere's growth rates, separated by commas:"); 
        growthRates = ParsePositiveDoubles(Console.ReadLine(), ',');

        // 4. Create a new sphere at the given position with the given radius and growth rates
        sphere = new Sphere(sphereCentre, radius);

        // 5. Read the collision point from the console using the ReadPoint() method, and the prompt:
        // "Enter the collision point X, Y, Z:"
        collisionPoint = ReadPoint("Enter the collision point X, Y, Z:");

        // 6. If the collision point is not inside the sphere, do the following:
        if (!sphere.ContainsPoint(collisionPoint))
        {
            foreach(double rate in growthRates)
            {
                sphere.GrowthRate = rate;
                sphere.Grow();
                secondsElapsed++;
                if (sphere.ContainsPoint(collisionPoint)) { break; }
            }
        }

        // 7. Loop through the growth rates

        // 8. Set the sphere's growth rate and grow the sphere

        // 9. Increment the number of seconds elapsed by 1

        // 10. Check for collision again. If the collision point is inside the sphere, break out of the loop

        // 11. If the collision point is inside the sphere, display the following message to the console:
        // "The sphere collided with the point and stopped growing."
        // Otherwise, display the following message to the console:
        // "The sphere did not collide with the point."
        if (sphere.ContainsPoint(collisionPoint))
        {
            Console.WriteLine("The sphere collided with the point and stopped growing.");
        }
        else 
        { 
            Console.WriteLine("The sphere did not collide with the point."); 
        }

        // 12. Display the number of seconds elapsed, the sphere's radius and volume to the console
        // using the following format:
        // $"After {secondsElapsed} seconds, the sphere's volume is {sphere.Volume:0.00}"
        // where X is the number of seconds elapsed, and Y is the sphere's volume at the time of collision
        Console.WriteLine($"After {secondsElapsed} seconds, the sphere's volume is {sphere.Volume:0.00}");

        // Keep the following line intact
        Console.WriteLine("===========================");
    }
    
    /// <summary>
    /// Reads an array of positive doubles from the console.
    /// Invalid inputs are ignored.
    /// </summary>
    /// <param name="input">(string) The input string containing the doubles</param>
    /// <param name="separator">(char) The character that separates the doubles</param>
    /// <returns>(List<result>) The array of doubles entered by the user</returns> 
    static List<double> ParsePositiveDoubles(string? input, char separator)
    {
        // Create a new list to store the doubles
        List<double> result = new List<double>();

        // If the input is null, return the empty list
        if(input == null)
        {
            return result;
        }

        // Split the input into parts using the separator
        List<string> parts = input.Split(separator).ToList();

        // For each part, try to parse it into a positive double
        // and add it to the list if successful
        foreach (string part in parts)
        {
            if (double.TryParse(part.Trim(), out double d))
            {
                result.Add(d);
            }
        }

        // Return the list of doubles parsed from the input
        return result;
    }

    /// <summary>
    /// Checks if the provided string is made of only numerical characters
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsAllDigits(string input)
    {
        foreach (char character in input)
        {
            if (!char.IsDigit(character))
                return false;
        }
        return true;
    }

    /* The following methods are provided for you. You do not need to modify them. */

    /// <summary>
    /// Reads a point from the console
    /// </summary>
    /// <param name="prompt">(string) The prompt to display to the user</param>
    static Point ReadPoint(string prompt)
    {
        Console.WriteLine(prompt);
        Point result;
        // Get the position from the user
        while (!Point.TryParse(Console.ReadLine(), out result!))
        {
            Console.WriteLine("Invalid input. Point must be in the form X, Y, Z:");
        }
        return result;
    }

    /// <summary>
    /// Reads a positive double from the console
    /// </summary>
    /// <param name="prompt">(string) The prompt to display to the user</param>
    /// <returns>(double) The double entered by the user</returns>
    static double ReadPositiveDouble(string prompt)
    {
        Console.WriteLine(prompt);
        double result;
        // Get the position from the user
        while (!double.TryParse(Console.ReadLine(), out result) || result <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
        }
        return result;
    }
}