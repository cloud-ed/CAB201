using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace EnterUppercaseLetters
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            string border = "===================================\n";
            string approve = "Ok";
            string deny = "Error";
            char quit = '!';
            // Ask for input
            while (true)
            {
                Console.WriteLine($"{border} Please input an uppercase letter:\n        or input ! to quit.\n{border}");
                char userInput = char.Parse(Console.ReadLine());
                if (userInput == quit)
                {
                    break;
                }
                else if (char.IsUpper(userInput))
                {
                    Console.WriteLine("{0}.", approve);
                }
                else
                {
                    Console.WriteLine("{0}.", deny);
                }
            }
        }
    }
}