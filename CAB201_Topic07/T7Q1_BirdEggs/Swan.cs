namespace BirdEggs;
class Swan : IBird, IFlyable, ISwimmable
{
    // Insert your solution here
    public string GetSound()
    {
        return "Honk honk";
    }

    public Egg LayEgg()
    {
        return new Egg(EggType.Swan);
    }

    public void Swim()
    {
        Console.WriteLine("A swan can swim");
    }
    public void Fly()
    {
        Console.WriteLine("A swan can fly");
    }
}