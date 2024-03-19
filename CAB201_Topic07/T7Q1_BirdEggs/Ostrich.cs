namespace BirdEggs;
class Ostrich : IBird, IRunnable
{
    // Insert your solution here
    public string GetSound()
    {
        return "Squawk squawk";
    }

    public Egg LayEgg()
    {
        return new Egg(EggType.Ostrich);
    }

    public void Run()
    {
        Console.WriteLine("An ostrich can run");
    }
}