using System;

namespace Factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Keep the following lines intact 
            Console.WriteLine("===========================");

            const string PROMPT = "Enter a value between 1 and 27:";
            const string OUT_FORMAT = "{0} factorial is {1}.";

            Console.WriteLine(PROMPT);
            string userInput = Console.ReadLine();
            decimal limit = decimal.Parse(userInput);

            decimal factorial = 1;

            // Insert your solution here.
            for (int i = 1; i <= limit; i++)
            {
                factorial *= i;
            }
            // Keep the following lines intact
            Console.WriteLine(OUT_FORMAT, limit, factorial);
            Console.WriteLine("===========================");
        }
    }
}