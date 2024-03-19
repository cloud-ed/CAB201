using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace DisplayRightAngleTriangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            string inputRequest = "Please input the number of rows you want:";
            string pyramid = "*";

            // Ask for input and add to sum.
            Console.WriteLine(inputRequest);
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(pyramid);
                pyramid = pyramid + "*";
            }
            Console.WriteLine("Enjoy your pyramid of {0} row/s high.", limit);
        }
    }
}