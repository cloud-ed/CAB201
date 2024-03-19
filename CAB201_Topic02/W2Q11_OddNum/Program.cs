using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace OddNum
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Define configs
            int limit = 99;

            // Ask for input
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}