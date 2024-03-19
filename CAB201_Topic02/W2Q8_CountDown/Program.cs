using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace CountDown
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            string border = "=============================\n";
            int upper = 1000;
            int lower = 0;
            // Ask for input
            for(int total = upper; total >= lower;)
            {
                Console.WriteLine("Please input a number:");
                int userInput = int.Parse(Console.ReadLine());
                total = total - userInput;
                Console.WriteLine($"The current total is {total}");
            }
            Console.WriteLine($"You have reached below {lower}.");
        }
    }
}