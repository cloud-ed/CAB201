namespace InheritanceOfSuperHeroes;
/// <summary>
/// A class representing a "enhanced human" SuperHero. Enhanced humans have
/// super powers, but only when they are in their "enhanced" state.
/// </summary>
class EnhancedHuman : SuperHero
{
    /** USE THE XML DOCUMENTATION PROVIDED BELOW TO IMPLEMENT THE FOLLOWING:
        - Private fields: enhanced (bool), powerSet (List<SuperPower>), sumOfPowers (int)
        - A constructor that takes a name, secret identity, and list of powers
        - An override for the SwitchIdentity method
        - An override for the HasPower method
        - An override for the TotalPower property
    **/
    private bool enhanced;
    private List<SuperPower> powerSet;
    private int sumOfPowers;

    /// <summary>
    /// Constructs a new EnhancedHero instance with specified identities 
    /// and SuperPowers (uses the base constructor for SuperHero). EnhancedHumans
    /// are not enhanced upon construction.
    /// </summary>
    /// <param name="trueIdentity">(string) The true identity of the EnhancedHuman</param>
    /// <param name="alterEgo">(string) The alter ego of the EnhancedHuman</param>
    /// <param name="myPowers">(List<SuperPower>) A list of SuperPowers the EnhancedHuman possesses</param>
    public EnhancedHuman(string trueIdentity, string alterEgo, List<SuperPower> myPowers) : base(trueIdentity, alterEgo)
    {
        enhanced = false;
        powerSet = myPowers;
        sumOfPowers = myPowers.Count;
    }

    /// <summary>
    /// SwitchIdentity method switches the current identity with other identity of the 
    /// EnhancedHuman. When their identity is switched, their enhanced state 
    /// is also toggled.
    /// </summary>
    public override void SwitchIdentity()
    {
        base.SwitchIdentity();
        if (enhanced == true) { enhanced = false; }
        else { enhanced = true; }
    }

    /// <summary>
    /// HasPower method determines whether the EnhancedHuman has a particular SuperPower. 
    /// EnhancedHumans only have SuperPowers in their enhanced state.
    /// </summary>
    /// <param name="whatPower">(SuperPower) The SuperPower to be queried</param>
    /// <returns>(bool) True is the EnhancedHuman has the provided SuperPower,
    ///     false otherwise</returns>
    public override bool HasPower(SuperPower whatPower)
    {
        if (enhanced == true)
        {
            if (powerSet.Contains(whatPower)) { return true; }
            else { return false; }
        }
        else return false;
    }

    /// <summary>
    /// TotalPower property returns the total power of the EnhancedHuman based 
    /// on their SuperPowers. EnhancedHumans only have SuperPowers in 
    /// their enhanced state.
    /// </summary>
    /// <returns>The total power of the EnhancedHuman</returns>
    public override int TotalPower
    {
        get
        {
            if (enhanced == true)
            {
                int TotalPower = 0;
                foreach (SuperPower power in powerSet)
                {
                    TotalPower += (int)power;
                }
                return TotalPower;
            }
            else { return 0; }
        }
    }
}