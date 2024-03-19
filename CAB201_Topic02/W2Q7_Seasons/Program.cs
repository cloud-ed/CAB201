using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Seasons
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            string border = "=============================\n";
            string summer = "Summer";
            string autumn = "Autumn";
            string winter = "Winter";
            string spring = "Spring";
            string error = "The data is out of range";
            string season;

            // Ask for input
            Console.WriteLine($"{border} Please input a month number:\n{border}");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                case 2:
                case 12:
                    season = summer; break;
                case 3:
                case 4:
                case 5:
                    season = autumn; break;
                case 6:
                case 7:
                case 8:
                    season = winter; break;
                case 9:
                case 10:
                case 11:
                    season = spring; break;
                default: season = error; break;
            }
            Console.WriteLine($"The season of that month is {season}.");
        }
    }
}