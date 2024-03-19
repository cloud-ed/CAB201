namespace BirdEggs;
enum EggType
{
    Chicken, // Cannot swim, fly or run
    Duck, // Can only swim
    Ostrich, // Can only run
    Dove, // Can only fly
    Swan // Can fly and swim
}
class Egg
{
    public EggType Type { get; private set; }
    public Egg(EggType type)
    {
        Type = type;
    }
    public IBird Hatch()
    {
        switch (Type)
        {
            // Insert your solution here to return the correct bird type
            // based on the Type of the egg
            case EggType.Chicken:
                return new Chicken();
            case EggType.Duck:
                return new Duck();
            case EggType.Ostrich:
                return new Ostrich();
            case EggType.Dove:
                return new Dove();
            case EggType.Swan:
                return new Swan();
            default:
                throw new Exception("Unknown egg type");
        }
    }
}