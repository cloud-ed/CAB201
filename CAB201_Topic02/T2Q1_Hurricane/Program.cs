using System;

namespace Hurricane
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Keep the following lines intact 
            Console.WriteLine("===========================");

            const string PROMPT = "Please enter the wind speed (km/h):";
            const string OUT_FORMAT = "If the wind speed is {0} then {1}.";

            Console.WriteLine(PROMPT);
            string userInput = Console.ReadLine();
            int windSpeed = int.Parse(userInput);

            string message = "";

            // Insert your solution here.
            const int thresh_1 = 118;
            const int thresh_2 = 153;
            const int thresh_3 = 177;
            const int thresh_4 = 208;
            const int thresh_5 = 251;
            {
                if (windSpeed <= thresh_1)
                {
                    message = "the damage from winds is minimal";
                }
                else if (windSpeed <= thresh_2)
                {
                    message = "very dangerous winds will produce some damage";
                }
                else if (windSpeed <= thresh_3)
                {
                    message = "extremely dangerous winds cause extensive damage";
                }
                else if (windSpeed <= thresh_4)
                {
                    message = "devastating damage will occur";
                }
                else if (windSpeed <= thresh_5)
                {
                    message = "catastrophic damage will occur";
                }
                else
                {
                    message = "cataclysmic damage will occur";
                }
            }
            // Keep the following lines intact
            Console.WriteLine(OUT_FORMAT, windSpeed, message);
            Console.WriteLine("===========================");
        }
    }
}