namespace InheritanceOfSuperHeroes;
/// <summary>
/// Enumeration that lists various super powers commonly available to comic
/// book superheroes and associates a (subjective) value with each superpower.
/// This list of powers is by no means comprehensive.
/// </summary>
public enum SuperPower
{
    Flight = 100,
    SuperStrength = 75,
    XRayVision = 20,
    SuperSpeed = 40,
    Invulnerability = 150,
    SuperIntellect = 90
}

/// <summary>
/// An abstract class representing a super hero. Super heroes have two 
/// identities and may have various super powers or none at all.
/// </summary>
/// <remarks>
/// This class has been partially implemented for you. You will need to
/// complete the implementation of this class by implementing the SwitchIdentity
/// virtual method.
/// </remarks> 
public abstract class SuperHero
{
    private string otherIdentity;
    public string CurrentIdentity { get; protected set; }

    /// <summary>
    /// Returns the total power of the SuperHero based on their SuperPowers
    /// </summary>
    /// <returns>The total power of the SuperHero</returns>
    public abstract int TotalPower { get; }

    /// <summary>
    /// Constructs a new SuperHero instance with specified identities
    /// </summary>
    /// <param name="trueIdentity">The true identity of the super hero</param>
    /// <param name="alterEgo">The alter ego of the super hero</param>
    public SuperHero(string trueIdentity, string alterEgo)
    {
        CurrentIdentity = trueIdentity;
        otherIdentity = alterEgo;
    }

    /// <summary>
    /// Gets the integer value associated with a particular SuperPower
    /// </summary>
    /// <param name="power">The SuperPower</param>
    /// <returns>The associated integer value</returns>
    public static int GetPowerValue(SuperPower power)
    {
        return (int)power;
    }

    // ========================== YOUR WORK HERE ==============================

    /// <summary>
    /// Switches the current identity with other identity of the hero
    /// </summary>
    public virtual void SwitchIdentity()
    {
        string temp = CurrentIdentity;
        CurrentIdentity = otherIdentity;
        otherIdentity = temp;
    }

    // ========================== END OF YOUR WORK ============================

    /// <summary>
    /// Determines whether the SuperHero has a particular SuperPower
    /// </summary>
    /// <param name="whatPower">The SuperPower to be queried</param>
    /// <returns>True is the SuperHero has the provided SuperPower, false otherwise</returns>
    public abstract bool HasPower(SuperPower whatPower);
}