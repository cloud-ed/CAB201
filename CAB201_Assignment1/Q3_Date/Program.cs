using System;

namespace Q3
{
    public class Q3
    {
        static void Main()
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            
            // Assign values
            string monthPrompt = "Enter the month:";
            string dayPrompt = "Enter the day:";
            string result = "Combination ({0},{1}) is {2}.";
            string checkResult = "";
            string invalid = "invalid";
            string valid = "valid";

            // Prompt for values
            Console.WriteLine(monthPrompt);
            int monthInput = int.Parse(Console.ReadLine());
            Console.WriteLine(dayPrompt);
            int dayInput = int.Parse(Console.ReadLine());

            // Check validity
            if (monthInput < 1 || monthInput > 12)
            {
                checkResult = invalid;
            }
            else
            {
                if (dayInput < 1 || dayInput > 31)
                {
                    checkResult = invalid;
                }
                else
                {
                    if (dayInput == 31)
                    {
                        switch (monthInput)
                        {
                            case 2:
                                break;
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                checkResult = invalid; break;
                            default:
                                checkResult = valid; break;
                        }
                    }
                    else if (monthInput == 2)
                    {
                        if (dayInput > 28)
                        {
                            checkResult = invalid;
                        }
                        else
                        {
                            checkResult = valid;
                        }
                    }
                    else if (checkResult == "")
                    {
                        checkResult = valid;
                    }
                }
            }

            // Print validity
            Console.WriteLine((result), monthInput, dayInput, checkResult);

            // Keep the following line intact
            Console.WriteLine("===========================");
        }
    }
}