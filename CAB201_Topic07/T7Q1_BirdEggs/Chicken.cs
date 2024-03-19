namespace BirdEggs;
class Chicken : IBird
{
    // Insert your solution here
    public string GetSound()
    {
        return "Cluck cluck";
    }

    public Egg LayEgg()
    {
        return new Egg(EggType.Chicken);
    }
}