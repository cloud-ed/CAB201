using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace CheckScore
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            string pass = "C";
            string achieve = "B";
            string overachieve = "A";
            int score1 = 50;
            int score2 = 75;
            int score3 = 100;

            // Ask for input
            Console.WriteLine("Please input your score:");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput < score1)
            {
                Console.WriteLine(pass);
            }
            else if (userInput <= score2)
            {
                Console.WriteLine(achieve);
            }
            else if (userInput <= score3)
            {
                Console.WriteLine(overachieve);
            }
        }
    }
}