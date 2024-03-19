using System;
using System.Security.Cryptography;

namespace CsvParse
{
    public class Program
    {
        static void Main()
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            // Get input
            Console.WriteLine("Please enter a list of integer values separated by commas:");
            string userInput = Console.ReadLine();

            // Check if input is valid and continue
            if (userInput == null) { userInput = ""; }
            Console.WriteLine("---------------------------");
            if (userInput.Length == 0)
            {
                Console.WriteLine("The supplied list is empty.");
            }
            else
            {
                // Split the string into string array
                userInput = userInput.Trim();
                string[] parts = new string[userInput.Length];
                parts = userInput.Split(',');

                // Convert string array to int array
                int[] values = new int[parts.Length];
                for (int i  = 0; i < parts.Length; i++)
                {
                    values[i] = int.Parse(parts[i]);
                }

                // Display each value and it's square
                for (int i = 0;i < values.Length; i++)
                {
                    Console.WriteLine($"The square of {values[i]} is {values[i] * values[i]}.");
                }
            }

            // Keep the following line intact
            Console.WriteLine("===========================");
        }
    }
}