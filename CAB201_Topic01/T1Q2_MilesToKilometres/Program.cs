using System;

namespace MilesToKilometres
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            //  Display prompt
            Console.WriteLine("Please supply the distance in miles:");
            //  Read number of miles
            string userInput = Console.ReadLine();
            double M = double.Parse(userInput);
            //  Compute equivalent number of kilometres
            double K = M * 1.609344;
            //  Display message involving miles and kilometres
            Console.WriteLine($"{M:F4} miles is the same as {K:F4} kilometres.");
            // Keep the following line intact 
            Console.WriteLine("===========================");
        }
    }
}