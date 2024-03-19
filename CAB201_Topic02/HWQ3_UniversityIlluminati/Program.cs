using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace UniversityIlluminati
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define variables
            string msg1 = "Guaranteed membership";
            string msg2 = "Almost guaranteed membership";
            string msg3 = "A good chance of membership";
            string msg4 = "Cross your fingers";
            string msg5 = "Unlikely";
            double GPA1 = 6.0;
            double GPA2 = 5.0;
            double GPA3 = 4.0;
            int testScore1 = 85;
            int testScore2 = 70;
            int testScore3 = 50;

            // Ask for input
            Console.WriteLine("Please input your test score:");
            int userScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your GPA:");
            double userGPA = double.Parse(Console.ReadLine());

            // Analyse inputs
            if (userScore >= testScore1 && userGPA >= GPA1)
            {
                Console.WriteLine(msg1);
            }
            else if (userScore >= testScore2 && userGPA >= GPA1)
            {
                Console.WriteLine(msg2);
            }
            else if (userScore >= testScore2 && userGPA >= GPA2)
            {
                Console.WriteLine(msg3);
            }
            else if (userScore >= testScore3 && userGPA >= GPA3)
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