using System.Collections.Generic;

namespace LinkedLists;
class Program
{
    static void Main(string[] args)
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");

        // Insert your solution here.
        string sequencePrompt = "Enter a floating point value (or 'q' to quit):";
        LinkedList newList = new LinkedList();

        // While-loop until quit
        Console.WriteLine(sequencePrompt);
        string userInput = Console.ReadLine();
        while (userInput != "q")
        {
            newList.Add(double.Parse(userInput));
            Console.WriteLine(sequencePrompt);
            userInput = Console.ReadLine();
        }

        // Check if empty and return error or print sum
        if (newList.IsEmpty())
        {
            Console.WriteLine("Cannot calculate sum of empty list.");
        }
        else
        {
            Console.WriteLine($"The sum of the values is: {newList.Sum()}.");
        }
        // Keep the following line intact
        Console.WriteLine("===========================");
    }
}