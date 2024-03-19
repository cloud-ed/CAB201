using System;

namespace Q1
{
    public class Q1
    {
        static void Main()
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            string chickenPrompt = "Enter the number of chickens:";
            string eggPrompt = "Eggs:";
            int total = 0;
            string result = "";

            // Prompt for chicken and egg count, add eggs to total if eggs > 0
            Console.WriteLine(chickenPrompt);
            int userInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(eggPrompt);
                int eggs = int.Parse(Console.ReadLine());
                if (eggs > 0)
                {
                    total += eggs;
                }
            }

            // Calculate dozens and total remaining
            int remaining = total;
            int dozen = 0;
            while (remaining >=12)
            {
                if (remaining >= 12)
                {
                    dozen++;
                    remaining = remaining - 12;
                }
            }


            // Form final response
            {
                if (total != 1)
                {
                    result = result + "You have {0} eggs ";
                }
                else
                {
                    result = result + "You have {0} egg ";
                }
            }

            {
                if (dozen > 1)
                {
                    result = result + "which equals {1} dozen ";
                }
                else
                {
                    result = result + "which equals {1} dozen ";
                }
            }

            {
                if (remaining != 1)
                {
                    result = result + "and {2} eggs left over.";
                }
                else
                {
                    result = result + "and {2} egg left over.";
                }
            }

            // Print final response
            Console.WriteLine((result), total, dozen, remaining);

            // Keep the following lines intact
            Console.WriteLine("===========================");
        }
    }
}