using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace SumFiveInts
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            string inputRequest = "Please input a number:";
            int limit = 5;
            int sum = 0;

            // Ask for input and add to sum
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(inputRequest);
                int userInput = int.Parse(Console.ReadLine());
                sum += userInput;
            }
            Console.WriteLine($"The final sum of the {limit} numbers is {sum}.");
        }
    }
}