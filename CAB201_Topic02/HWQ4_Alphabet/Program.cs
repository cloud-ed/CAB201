using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Alphabet
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define variables
            string vowel = "Vowel";
            string notVowel = "Not a vowel";

            // Ask for input
            Console.WriteLine("Please input a letter");
            string userInput = Console.ReadLine();

            // Analyse the user input
            switch (userInput)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine(vowel); break;
                default: 
                    Console.WriteLine(notVowel); break;
            }
        }
    }
}