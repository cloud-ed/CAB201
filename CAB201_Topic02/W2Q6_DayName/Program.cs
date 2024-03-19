using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace DayName
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            string border = "=============================\n";
            string day0 = "Sunday";
            string day1 = "Monday";
            string day2 = "Tuesday";
            string day3 = "Wednesday";
            string day4 = "Thursday";
            string day5 = "Friday";
            string day6 = "Saturday";
            string dayError = "Error";
            string day;

            // Ask for input
            Console.WriteLine($"{border} Please input the day number\n{border}");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 0: day = day0; break;
                case 1: day = day1; break;
                case 2: day = day2; break;
                case 3: day = day3; break;
                case 4: day = day4; break;
                case 5: day = day5; break;
                case 6: day = day6; break;
                default: day = dayError; break;
            }
            Console.WriteLine($"The day that you entered is {day}.");
        }
    }
}