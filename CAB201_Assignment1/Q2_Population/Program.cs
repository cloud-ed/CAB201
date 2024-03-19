using System;

namespace Q2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            // Assign values
            string simPrompt = "Enter the simulation period (whole years):";
            string simCancel = "Simulation cancelled: no years.";
            string townPrompt = "Enter the number of towns:";
            string townCancel = "Simulation cancelled: no towns.";
            string namePrompt = "Enter the name of the town:";
            string popPrompt = "Enter the initial population of the town:";
            string growthPrompt = "Enter the growth rate of the town:";
            double currentPop = 0;

            // Check simulation length
            Console.WriteLine(simPrompt);
            int yearInput = int.Parse(Console.ReadLine());
            if (yearInput < 1)
            {
                Console.WriteLine(simCancel);
            }
            else
            {
                Console.WriteLine(townPrompt);
                int townInput = int.Parse(Console.ReadLine());
                if (townInput < 1)
                {
                    Console.WriteLine(townCancel);
                }

            // For loop for each number of town in townInput
                else
                {
                    for (int i = 0; i < townInput; i++) 
                    {
                        Console.WriteLine(namePrompt);
                        string nameInput = Console.ReadLine();
                        Console.WriteLine(popPrompt);
                        int popInput = int.Parse(Console.ReadLine());
                        Console.WriteLine(growthPrompt);
                        double growthInput = double.Parse(Console.ReadLine());
                        currentPop = popInput;
                        for (int o = 0; o < yearInput; o++)
                        {
                            currentPop *= growthInput;
                            currentPop = Math.Round(currentPop, 0);
                        }
                        double finalPop = Math.Round(currentPop, 0);
                        Console.WriteLine($"The population of {nameInput} goes from {popInput} to {finalPop} with growth factor {growthInput} after {yearInput} years.");
                    }
                }
            }
            // Keep the following lines intact
            Console.WriteLine("===========================");
        }
    }
}