using System;

namespace RoomArea
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            Console.WriteLine("Please enter the width of the room, in metres:");
            string widthInput = Console.ReadLine();
            double W = double.Parse(widthInput);
            Console.WriteLine("Please enter the length of the room, in metres:");
            string lengthInput = Console.ReadLine();
            double L = double.Parse(lengthInput);
            double A = W * L;
            Console.WriteLine($"The floor area of a {W:F7} by {L:F7} metre room is {A:F7} square metres.");
            // Keep the following line intact 
            Console.WriteLine("===========================");
        }
    }
}