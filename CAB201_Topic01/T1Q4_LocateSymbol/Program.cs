using System;
using System.Security.Cryptography;

namespace LocateSymbol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            Console.WriteLine("Please enter a line of text:");
            string userInput = Console.ReadLine();
            int Y = userInput.IndexOf('@');
            int Z = userInput.LastIndexOf('@');
            Console.WriteLine($"The first and last positions of '@' are {Y} and {Z}, respectively.");

            // Keep the following line intact 
            Console.WriteLine("===========================");
        }
    }
}