using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace AgeDisplay
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            string resp1 = "You're old enough to drive.";
            string resp2 = "Fancy an alocholic beverage.";
            string resp3 = "Enjoy your retirement.";
            string resp4 = "You are too young to drive, drink or retire.";
            int drive = 16;
            int drink = 18;
            int retire = 65;
            // Ask for input
            Console.WriteLine("=========================== \n How old are you? \n===========================\n");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput >= retire)
            {
                Console.WriteLine(resp3);
            }
            else if (userInput >= drink)
            {
                Console.WriteLine(resp2);
            }
            else if (userInput >= drive)
            {
                Console.WriteLine(resp1);
            }
            else
            {
                Console.WriteLine(resp4);
            }
        }
    }
}