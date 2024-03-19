using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace CheckCredit
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            string approve = "Approved.";
            string deny = "Error - Purchase price is greater than credit.";
            int credit = 8000;
            int minVal = 0;
            int quit = 000;

            // Ask for input
            Console.WriteLine("Please input a credit limit:\nor input 0 to skip.\n");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput != quit)
            {
                credit = userInput;
            }
            Console.WriteLine("Your credit limit is: {0}.\nPlease input an item's price:", credit);
            userInput = int.Parse(Console.ReadLine());
            if (userInput > credit)
            {
                Console.WriteLine(deny);
            }
            else if (userInput > minVal)
            {
                Console.WriteLine(approve);
            }
        }
    }
}