namespace BirdEggs;
class Program
{
    /// <summary>
    /// The main entry point of the program. DO NOT MODIFY THIS METHOD.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("===========================");
        List<Egg> eggs = new List<Egg>();
        for (int i = 0; ; i++)
        {
            Console.WriteLine($"Enter the type of egg {i + 1}, must be one of [Chicken, Dove, Duck, Ostrich, Swan]. Enter 'exit' to stop.");
            string eggType = Console.ReadLine();
            if (eggType == "exit") break;
            Egg egg = new Egg(Enum.Parse<EggType>(eggType));
            eggs.Add(egg);
        }

        // Hatches the eggs into birds and display their types
        Console.WriteLine("--------Hatching eggs-------");
        List<IBird> birds = Incubate(eggs);
        Console.WriteLine("The birds that hatched are:");
        foreach (IBird bird in birds)
        {
            Console.WriteLine("\t" + bird.GetType().Name);
        }

        // Makes the birds sing
        Console.WriteLine("--------Making birds sing-------");
        Console.WriteLine("Looks like the birds are singing:");
        MakeBirdsSing(birds);

        // Spawns an egg by selecting a bird from the list of birds
        // and have it lay an egg, then hatch the egg into a bird.
        Console.WriteLine("--------Spawning a bird-------");
        SpawnBird(birds);

        // Displays the actions of the birds
        Console.WriteLine("--------Displaying bird actions-------");
        DisplayBirdActions(birds);

        Console.WriteLine("===========================");
    }

    /// <summary>
    /// Hatches a given list of eggs into a list of birds
    /// </summary>
    /// <param name="eggs">The eggs to hatch</param>
    /// <returns>The list of birds that hatched from the eggs</returns>
    static List<IBird> Incubate(List<Egg> eggs)
    {
        // Insert your solution here, to:
        //  1. Create a list of birds
        List<IBird> birds = new List<IBird>();
        //  2. Iterate through the eggs list, hatching each egg into a bird 
        //     and adding it to the list of birds
        foreach(Egg egg in eggs)
        {
            birds.Add(egg.Hatch());
        }
        //  3. Return the list of birds
        return birds;
    }

    /// <summary>
    /// Haves a given list of birds make their respective sounds
    /// </summary>
    /// <param name="birds">The birds to make their sounds</param>
    static void MakeBirdsSing(List<IBird> birds)
    {
        // Insert your solution here, to iterate through the birds list
        // and display the message
        // "The <bird.GetType().Name> sounded like: <bird sound>"
        // Where <bird.GetType().Name> is the type of the bird 
        // and <bird sound> is the sound the bird makes
        foreach(IBird bird in birds)
        {
            Console.WriteLine($"The {bird.GetType().Name} sounded like: {bird.GetSound()}");
        }
    }

    /// <summary>
    /// Gets the actions of a given list of birds, if they are able to perform them.
    /// The possible actions involve flying, swimming and running.
    /// </summary>
    /// <param name="birds">The birds to get their actions</param>
    static void DisplayBirdActions(List<IBird> birds)
    {
        // Insert your solution here, to iterate through the birds list
        // and for each bird:
        // 0. Display the message ">>> <bird.GetType().Name> <<<" to indicate the current bird
        // 1. If the bird is an instance of IFlyable:
        //      a. Cast the bird to IFlyable and store it in a variable
        //      b. Call the Fly() method on the variable
        // 2. If the bird is an instance of ISwimmable:
        //      a. Cast the bird to ISwimmable and store it in a variable
        //      b. Call the Swim() method on the variable
        // 3. If the bird is an instance of IRunnable:
        //      a. Cast the bird to IRunnable and store it in a variable
        //      b. Call the Run() method on the variable
        // The first two steps are already done for you
        foreach (IBird bird in birds)
        {
            // Keep the following lines intact
            Console.WriteLine($">>> {bird.GetType().Name} <<<");
            if (bird is IFlyable)
            {
                IFlyable flyableBird = (IFlyable)bird;
                flyableBird.Fly();
            }
            // Insert your solution here
            if (bird is ISwimmable)
            {
                ISwimmable swimmableBird = (ISwimmable)bird;
                swimmableBird.Swim();
            }
            if (bird is IRunnable)
            {
                IRunnable runnableBird = (IRunnable)bird;
                runnableBird.Run();
            }
        }
    }

    /// <summary>
    /// Spawns an egg by selecting a bird from a given list of birds
    /// and have it lay an egg, then hatch the egg into a bird.
    /// The bird is then added to the list of birds. 
    /// </summary>
    /// <param name="birds">The list of birds to select from</param>
    static void SpawnBird(List<IBird> birds)
    {
        // Keep the following lines intact
        if (birds.Count == 0) return;
        Console.WriteLine("Select which bird to lay an egg, or enter 'none' to stop");
        for (int i = 0; i < birds.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {birds[i].GetType().Name}");
        }
        string selection = Console.ReadLine();
        if (selection == "none") return;
        int birdIndex = int.Parse(selection) - 1;

        // Insert your solution here, to:
        //  1. Call the LayEgg() method on the bird at the given index
        //  2. Hatch the egg into a bird and store it in a variable
        //  3. Add the bird to the list of birds

        Egg egg = birds.ElementAt(birdIndex).LayEgg();
        IBird bird = egg.Hatch();
        birds.Add(bird);

        // Keep the following lines intact
        Console.WriteLine($"A new {bird.GetType().Name} hatched from the egg");
    }
}