using System;

namespace UniversityResult
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            const string PROMPT = "Please enter the result code, an integer between 1 and 7:";
            const string OUT_FORMAT = "Result code {0} is classified as '{1}'.";

            Console.WriteLine(PROMPT);
            string userInput = Console.ReadLine();
            int resultCode = int.Parse(userInput);

            string description = "";

            switch (resultCode)
            {
                case 7: description = "High Distinction"; break;
                case 6: description = "Distinction"; break;
                case 5: description = "Credit"; break;
                case 4: description = "Pass"; break;
                case 3: description = "Failure"; break;
                case 2: description = "Failure"; break;
                case 1: description = "Failure"; break;
                default: description = "Invalid"; break;
            }

            // Keep the following line intact
            Console.WriteLine(OUT_FORMAT, resultCode, description);
            Console.WriteLine("===========================");
        }
    }
}