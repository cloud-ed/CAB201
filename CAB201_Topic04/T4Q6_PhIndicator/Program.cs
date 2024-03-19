using System.Runtime.InteropServices;

namespace PHIndicator;
class Program
{
    static void Main(string[] args)
    {
        // Keep the following line intact
        Console.WriteLine("===========================");
        IPHIndicator litmus, turmeric, universal;

        // Insert your solution here.
        // Prompt user for pH value (a double) using the following message:
        // "Enter the pH value of your solution:"
        Console.WriteLine("Enter the pH value of your solution:");
        string userInput = Console.ReadLine();
        double PHinput;
        while (true)
        {
            if (double.TryParse(userInput, out PHinput) != true)
            {
                Console.WriteLine("Invalid input.");
            }
            else { break; }
            userInput = Console.ReadLine();
        }

        // Create an instance of Litmus, Turmeric and UniversalIndicator.
        litmus = new Litmus();
        turmeric = new Turmeric();
        universal = new UniversalIndicator();

        // Set the pH value of the three instances to the user input.
        litmus.SetPh(PHinput);
        turmeric.SetPh(PHinput);
        universal.SetPh(PHinput);

        // Print the color of the three instances using the following message:
        // "The litmus paper turns {color} under this pH."
        // "The turmeric solution turns {color} under this pH."
        // "The universal indicator turns {color} under this pH."
        string color;
        color = litmus.GetColor();
        Console.WriteLine($"The litmus paper turns {color} under this pH.");
        color = turmeric.GetColor();
        Console.WriteLine($"The turmeric solution turns {color} under this pH.");
        color = universal.GetColor();
        Console.WriteLine($"The universal indicator turns {color} under this pH.");

        // Keep the following line intact
        Console.WriteLine("===========================");
    }
}