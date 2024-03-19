namespace BirdEggs;
class Duck : IBird, ISwimmable
{
    // Insert your solution here
    public string GetSound()
    {
        return "Quack quack";
    }

    public Egg LayEgg()
    {
        return new Egg(EggType.Duck);
    }

    public void Swim()
    {
        Console.WriteLine("A duck can swim");
    }
}