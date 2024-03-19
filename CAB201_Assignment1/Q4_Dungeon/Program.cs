namespace DungeonTask;
class Program
{
    static void Main(string[] args)
    {
        // Keep the following lines intact 
        Console.WriteLine("===========================");
        Console.WriteLine("Welcome to the dungeon!");
        Console.WriteLine("If you would like to add a room, enter the name of the enemy in the room.");
        Console.WriteLine("If you would like to stop, enter \"stop\".");
        string input = Console.ReadLine();

        // Insert your solution here
        // Initialize new dungeon
        Dungeon newDungeon = new Dungeon();

        // While-loop until quit
        while (input != "stop")
        {
            newDungeon.AddRoom(input);
            Console.WriteLine("Enter the name of the enemy in the next room or enter \"stop\".");
            input = Console.ReadLine();
        }
        Console.WriteLine("You entered the dungeon and saw the enemies in this order:");

        // Check if dungeon is empty and return empty if true else display all enemies encountered
        if (newDungeon.IsEmpty())
        {
            Console.WriteLine("The dungeon is empty.");
        }
        else
        {
            newDungeon.Display();
        }

        // Reverse room order and display enemies in the reverse order, else return empty
        newDungeon.Reverse();
        Console.WriteLine("You backtracked your way out of the dungeon and saw the enemies in this order:");
        if (newDungeon.IsEmpty())
        {
            Console.WriteLine("The dungeon is empty.");
        }
        else
        {
            newDungeon.Display();
        }

        // Keep the following line intact 
        Console.WriteLine("===========================");
    }
}