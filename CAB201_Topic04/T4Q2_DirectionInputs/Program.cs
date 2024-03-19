namespace DirectionalInputs;
class Program
{
    static void Main(string[] args)
    {
        // Keep the following lines intact 
        Console.WriteLine("===========================");
        int x = 0, y = 0;
        int distance;
        Console.WriteLine("Enter a path consisting of N, S, E, W: ");

        // Insert your solution here
        string userInput = Console.ReadLine();
        foreach(char c in userInput)
        {
            if (Direction.TryParse(c, out int xDiff, out int yDiff) == true)
            {
                x += xDiff;
                y += yDiff;
            }
            else
            {
                Console.WriteLine("Could not parse a character.");
            }
        }

        // Calculate the Manhattan distance from the into the variable called distance
        distance = Math.Abs(x) + Math.Abs(y);

        // Keep the following lines intact
        Console.WriteLine($"The Manhattan distance from the origin is {distance}.");
        Console.WriteLine("===========================");
    }
}