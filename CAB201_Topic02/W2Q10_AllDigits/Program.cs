using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace AllDigits
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            int limit = 9;

            // Ask for input
            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}