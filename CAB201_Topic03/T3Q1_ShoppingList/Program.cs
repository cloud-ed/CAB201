using System;
using System.Collections.Generic;

namespace ShoppingList
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            string itemCountPrompt = "How many items are there?";
            string itemNamePrompt = "Please enter an item:";
            string listHeader = "----------------------------\nYour shopping list contains:\n----------------------------";

            // Prompt list size
            Console.WriteLine(itemCountPrompt);
            int itemCount = int.Parse(Console.ReadLine());
            if (itemCount < 1)
            {
                itemCount = 0;
            }
            string[] itemList = new string[itemCount];

            // Get name of items
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine(itemNamePrompt);
                itemList[i] = Console.ReadLine();
            }

            // Sort items and print list header
            Array.Sort(itemList);
            Console.WriteLine(listHeader);

            // Print each item on a seperate line
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"Item {i}: {itemList[i]}");
            }

            // Keep the following line intact
            Console.WriteLine("===========================");
        }
    }
}
