namespace BirdEggs;
class Dove : IBird, IFlyable
{
    // Insert your solution here

    public string GetSound()
    {
        return "Chirp chirp";
    }

    public void Fly()
    {
        Console.WriteLine("A dove can fly");
    }

    public Egg LayEgg()
    {
        return new Egg(EggType.Dove);
    }
}