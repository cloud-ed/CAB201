using System;
using System.Collections.Generic;

namespace MedianTemperature
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            // Initialise list and values
            List<double> temps = new List<double>();
            double median;
            double userInput;

            // User input of temps
            Console.WriteLine("Please enter a temperature reading, or 99999999 to finish:");
            userInput = double.Parse(Console.ReadLine());
            while (userInput != 99999999)
            {
                temps.Add(userInput);
                Console.WriteLine("Please enter a temperature reading, or 99999999 to finish:");
                userInput = double.Parse(Console.ReadLine());
            }

            // Check if list is empty - return message if empty, else continue
            if (temps.Count == 0)
            {
                Console.WriteLine("Median is not defined for an empty list.");
            }
            // Do math depending on whether the value is even or odd
            else
            {
                temps.Sort();
                int n = temps.Count;
                if (n == 1) { median = temps[0]; }
                else
                {
                    if ((n % 2) != 0)
                    {
                        median = temps[n / 2];
                    }
                    else
                    {
                        median = (temps[n / 2] + temps[n / 2 - 1]) / 2;
                    }
                }
                string roundM = Math.Round(median, 2).ToString("F2");
                Console.WriteLine($"The median is {roundM} degrees.");
            }

            // Keep the following line intact
            Console.WriteLine("===========================");
        }
    }
}