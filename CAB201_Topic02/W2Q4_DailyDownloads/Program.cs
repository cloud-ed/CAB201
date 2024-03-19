using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace DailyDownloads
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            int thresh1 = 100;
            int thresh2 = 1000;
            int thresh3 = 10000;
            int thresh4 = 100000;

            string msg1 = "Daily downloads: <100.";
            string msg2 = "Daily downloads: 100-1,000";
            string msg3 = "Daily downloads: 1,001-10,000";
            string msg4 = "Daily downloads: 10,000-100,000";
            string msg5 = "Daily downloads: 100,000+";

            // Ask for input
            Console.WriteLine("=========================== \n How many daily downloads were there? \n===========================\n");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput < thresh1)
            {
                Console.WriteLine(msg1);
            }
            else if (userInput <= thresh2)
            {
                Console.WriteLine(msg2);
            }
            else if (userInput <= thresh3)
            {
                Console.WriteLine(msg3);
            }
            else if(userInput <= thresh4)
            {
                Console.WriteLine(msg4);
            }
            else
            {
                Console.WriteLine(msg5);
            }
        }
    }
}