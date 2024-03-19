using System.Linq;

namespace InheritanceOfSuperHeroes;
/// <summary>
/// A class representing a "super human" SuperHero. Super humans have
/// super powers, and can gain/lose super powers under certain conditions.
/// </summary>
class SuperHuman : SuperHero
{
    /** USE THE XML DOCUMENTATION PROVIDED BELOW TO IMPLEMENT THE FOLLOWING:
        - Private fields: powerSet (List<SuperPower>), sumOfPowers (int)
        - A constructor that takes a name, secret identity, and list of powers
        - An override for the HasPower method
        - An override for the TotalPower property
        - An AddSuperPower method
        - A LoseSinglePower method
        - A LoseAllSuperPowers method
    **/
    private List<SuperPower> powerSet;
    private int sumOfPowers;

    /// <summary>
    /// Constructs a new SuperHuman instance with specified identities 
    /// and SuperPowers (uses the base constructor for SuperHero).
    /// </summary>
    /// <param name="trueIdentity">The true identity of the SuperHuman</param>
    /// <param name="alterEgo">The alter ego of the SuperHuman</param>
    /// <param name="myPowers">A list of SuperPowers the SuperHuman possesses</param>
    public SuperHuman(string trueIdentity, string alterEgo, List<SuperPower> myPowers) : base(trueIdentity, alterEgo)
    {
        sumOfPowers = myPowers.Count;
        powerSet = myPowers;
    }

    /// <summary>
    /// HasPower method determines whether the SuperHuman has a particular SuperPower.
    /// </summary>
    /// <param name="whatPower">The SuperPower to be queried</param>
    /// <returns>True is the SuperHuman has the provided SuperPower,
    ///     false otherwise</returns>
    public override bool HasPower(SuperPower whatPower)
    {
        if (powerSet.Contains(whatPower)) { return true; }
        else { return false; }
    }

    /// <summary>
    /// TotalPower property returns the total power of the SuperHuman based on their SuperPowers.
    /// </summary>
    /// <returns>The total power of the SuperHuman</returns>
    public override int TotalPower
    {
        get
        {
            int TotalPower = 0;
            foreach (SuperPower power in powerSet)
            {
                TotalPower += (int)power;
            }
            return TotalPower;
        }
    }

    /// <summary>
    /// AddSuperPower method adds a new SuperPower to the set of SuperPowers the SuperHuman 
    /// possesses, and adjusts their total power accordingly. This method returns nothing.
    /// </summary>
    /// <param name="newPower">The new SuperPower</param>
    public void AddSuperPower(SuperPower newPower)
    {
        powerSet.Add(newPower);
        sumOfPowers++;
    }

    /// <summary>
    /// LoseSinglePower method removes a particular SuperPower from the set of SuperPowers the 
    /// SuperHuman possesses (if it exists), and adjusts their total 
    /// power accordingly. Does nothing if the SuperHuman does not
    /// possess the SuperPower. This method returns nothing.
    /// </summary>
    /// <param name="power">The SuperPower to be removed</param>
    public void LoseSinglePower(SuperPower power)
    {
        if (powerSet.Contains(power))
        {
            powerSet.Remove(power);
            sumOfPowers--;
        }
    }

    /// <summary>
    /// LoseAllSuperPowers method removes all SuperPowers that the SuperHuman possesses, and adjusts 
    /// their total power accordingly. This method returns nothing.
    /// </summary>
    public void LoseAllSuperPowers()
    {
        powerSet = new List<SuperPower>();
        sumOfPowers = 0;
    }
}