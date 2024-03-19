namespace TreasureHunt;
class Program
{
    static void Main(string[] args)
    {
        // Keep the following lines intact
        Console.WriteLine("===========================");
        Hunter hunter;
        Vector velocity, hunterPosition, treasurePosition;
        double distance;

        // Insert your solution here
        // 1. Read the hunter's initial position using the ReadPosition() K
        // method, and the prompt:
        // "Enter the hunter's initial position X,Y:"
        hunterPosition = ReadPosition("Enter the hunter's initial position X,Y:");

        // 2. Create a new hunter at the given position
        hunter = new Hunter(hunterPosition);

        // 3. Read the treasure's position using the ReadPosition() method, 
        // and the prompt:
        // "Enter the treasure's position X,Y:"
        treasurePosition = ReadPosition("Enter the treasure's position X,Y:");

        // 4. Calculate the initial distance between the hunter and the treasure
        // which is the magnitude of the difference between the hunter's position
        // and the treasure's position
        distance = hunter.position.magnitude(treasurePosition.x, treasurePosition.y);

        // 5. Read the hunter's velocity from the console and
        // parse it into a Vector using the prompt:
        // "Enter the hunter's velocity X,Y or 0,0 to stop:"
        hunter.velocity = ReadPosition("Enter the hunter's velocity X,Y or 0,0 to stop:");
        while (hunter.velocity.x != 0 || hunter.velocity.y != 0)
        {
            hunter.Move(hunter.position, hunter.velocity);
            distance = hunter.position.magnitude(treasurePosition.x, treasurePosition.y);
            Console.WriteLine($"The current distance between the hunter and the treasure is: {distance:0.00}");
            hunter.velocity = ReadPosition("Enter the hunter's velocity X,Y or 0,0 to stop:");
        }
        // As long as the hunter's velocity is not 0,0, do the following:

        // 6. Update the hunter's velocity and move the hunter
        // using the and Move() method


        // 7. Update distance between the hunter and the treasure
        // and display it to the console using the following format:
        // $"The current distance between the hunter and the treasure is: {distance:0.00}"


        // 8. Read the hunter's velocity from the console again
        // using the same prompt as before:

        // Keep the following lines intact
        Console.WriteLine($"The final distance between the hunter and the treasure is: {distance:0.00}");
        Console.WriteLine("===========================");
    }

    /// <summary>
    /// Reads a position from the console
    /// </summary>
    /// <param name="prompt">(string) The prompt to display to the user</param>
    /// <returns>(Vector) The position entered by the user</returns>
    static Vector ReadPosition(string prompt)
    {
        Console.WriteLine(prompt);
        Vector result;
        // Get the position from the user
        while (!Vector.TryParse(Console.ReadLine(), out result!))
        {
            Console.WriteLine("Invalid input. Vector must be in the form X, Y:");
        }
        return result;
    }
}