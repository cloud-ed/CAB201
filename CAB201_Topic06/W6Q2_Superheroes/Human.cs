namespace InheritanceOfSuperHeroes;
/// <summary>
/// A class representing a "human" super hero. Humans do not have any 
/// super powers, and instead rely on their intellect and technologies
/// </summary>
class Human : SuperHero
{
    /** USE THE XML DOCUMENTATION PROVIDED BELOW TO IMPLEMENT THE FOLLOWING:
        - A constructor that takes a name and secret identity
        - A HasPower method that returns false
        - A TotalPower method that returns 0
    **/

    /// <summary>
    /// Constructs a new Human instance with specified identities 
    /// (uses the base constructor for SuperHero).
    /// </summary>
    /// <param name="name">The real name of the Human</param>
    /// <param name="secretId">The secret identity of the Human</param>
    public Human(string name, string secretId) : base(name, secretId) { }

    /// <summary>
    /// HasPower method determines whether the Human has a particular SuperPower. Humans 
    /// have no powers.
    /// </summary>
    /// <param name="whatPower">The SuperPower to be queried</param>
    /// <returns>True is the Human has the provided SuperPower, false otherwise</returns>
    public override bool HasPower(SuperPower power)
    {
        return false;
    }

    /// <summary>
    /// TotalPower property calculates and returns the total power of the Human based on 
    /// their SuperPowers. Humans have no powers.
    /// </summary>
    /// <returns>The total power of the Human</returns>
    public override int TotalPower { get { return 0; } }
}