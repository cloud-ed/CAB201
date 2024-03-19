using System;

namespace EchoNameTrim
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            //  Display prompt
            Console.WriteLine("Hello there, what is your name?");
            //  Read name, trim leading and trailing white space
            string userInput = Console.ReadLine();
            string trimName = userInput.Trim();
            //  Display message involving name
            Console.WriteLine($"Nice to meet you {trimName}, welcome to CAB201.");

            // Keep the following line intact 
            Console.WriteLine("===========================");
        }
    }
}