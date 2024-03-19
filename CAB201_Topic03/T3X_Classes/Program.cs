using System;
using System.Collections.Generic;
using T3X_Classes;

namespace Extension
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initialize stuff
            bool validInput = false;

            // Request inputs
            Console.WriteLine("Please input the name of the person you want log:");
            string personInput = Console.ReadLine();
            Console.WriteLine($"Please input the name of the city {personInput} lives in:");
            string cityInput = Console.ReadLine();

            // Use inputs
            WhoLivesHere whoLivesHere = new WhoLivesHere(personInput, cityInput);

            // Ask if they want to see details and display if Y
            while (validInput == false)
            {
                Console.WriteLine("Do you want to review your details? \n             Y or N");
                char confirmInput = char.Parse(Console.ReadLine());
                if (char.ToUpper(confirmInput) == 'Y' || char.ToUpper(confirmInput) == 'N')
                {
                    if (char.ToUpper(confirmInput) == 'Y')
                    {
                        whoLivesHere.ShowDetails();
                        Console.WriteLine("Have a good day. :)");
                        validInput = true;
                    }
                    else if (char.ToUpper(confirmInput) == 'N')
                    {
                        Console.WriteLine("Have a good day. :)");
                        validInput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter Y or N");
                }
            }

        }
    }
}
