namespace FindQuantile;
class Program
{
    static void Main(string[] args)
    {
        // Keep the following line intact 
        Console.WriteLine("===========================");

        // Insert your solution here.
        string valueCountPrompt = "Enter the number of values: ";
        string errorMsg = "Error: number of values must be greater than 0.";
        string valuePrompt = "Enter a value: ";
        string quantilePrompt = "Enter the number to find the quantile of: ";
        double quantileFrequency = 0;

        // Prompt array size
        Console.WriteLine(valueCountPrompt);
        int valueCount = int.Parse(Console.ReadLine());
        if (valueCount <= 0)
        {
            Console.WriteLine(errorMsg);
        }
        else
        {
            double[] values = new double[valueCount];

            // Get list of values
            for (int i = 0; i < valueCount; i++)
            {
                Console.WriteLine(valuePrompt);
                values[i] = double.Parse(Console.ReadLine());
            }

            // Get quantile and solve
            Console.WriteLine(quantilePrompt);
            double quantileInput = double.Parse(Console.ReadLine());
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= quantileInput)
                {
                    quantileFrequency++;
                }
            }
            double quantilePercent = quantileFrequency / values.Length;
            Console.WriteLine($"The quantile of {quantileInput} for the given values is {Math.Round(quantilePercent, 2)}.");
        }

        // Keep the following line intact
        Console.WriteLine("===========================");
    }
}