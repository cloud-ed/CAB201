using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace MyConsoleColor
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            string rMsg = "This is red!";
            string gMsg = "I love green!";
            string yMsg = "It was all yellow";
            string eMsg = "Error";
            string border = "=============================================";
            string Msg;

            // Ask for input
            Console.WriteLine($"{border} \n Please input the background color you want: \n 1. Red\n 2. Green\n 3. Yellow\n{border}\n");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1: Console.BackgroundColor = ConsoleColor.Red; Msg = rMsg; break;
                case 2: Console.BackgroundColor = ConsoleColor.Green; Msg = gMsg; break;
                case 3: Console.BackgroundColor = ConsoleColor.Yellow; Msg = yMsg; break;
                default: Msg = eMsg; break;
            }
            Console.WriteLine(Msg);
        }
    }
}