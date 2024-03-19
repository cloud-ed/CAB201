using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace CheckLowRate
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            double minRate = 19.84;
            string success = $"Rate is above the minimum rate of ${minRate} per hour.";
            string failure = $"Rate is not above minimum rate of ${minRate} per hour.";
            string neutral = $"Rate is at the minimum rate of ${minRate} per hour.";

            // Ask for input and print whether they are at, below or above the minimum hourly rate
            Console.WriteLine("=========================== \n What is your hourly rate? \n===========================\n");
            double userInput = double.Parse(Console.ReadLine());
            if (userInput > minRate)
            {
                Console.WriteLine(success);
            }
            else if (userInput == minRate)
            {
                Console.WriteLine(neutral);
            }
            else
            {
                Console.WriteLine(failure);
            }
        }
    }
}