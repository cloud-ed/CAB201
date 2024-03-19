using System;
using System.Runtime.InteropServices;

namespace MicroBlog
{
    public class Program
    {
        static void Main(string[] args)
        {  
            // Define configs
            string success = "\nMessage successfully posted.";
            string failure = "\nYour message failed to post. Try reducing the character count to under 140 characters.\n";
            int maxChar = 140;

            // Ask for input - Give success or failure message. Loop on failure until success. 
            while (true)
            {
                Console.WriteLine("============================== \n What would you like to post? \n==============================\n");
                string userInput = Console.ReadLine();
                int charCount = userInput.Count();
                if (charCount > maxChar)
                {
                    Console.WriteLine(failure);
                }

                else
                {
                    Console.WriteLine(success); break;
                }
            }
            
        }
    }
}