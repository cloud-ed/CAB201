namespace TreasureHunt;
/// <summary>
/// A 2D vector with an X and Y component
/// </summary>
class Vector
{
    /* Use the XML documentation below to create three properties 
        - X (double), auto-implemented, publicly gettable and settable
        - Y (double), auto-implemented, publicly gettable and settable
        - Magnitude (double), publicly gettable
    */

    /// <summary>
    /// (double) The X component of the vector
    /// </summary>
    public double x {  get; set; }

    /// <summary>
    /// (double) The Y component of the vector
    /// </summary>
    public double y { get; set; }

    /// <summary>
    /// (double) The Euclidean length of the vector
    /// </summary>
    /// <remarks>
    /// The magnitude of a vector is the square root of the sum of the squares of its components, i.e.:
    /// magnitude = sqrt(x^2 + y^2)
    /// </remarks>
    public double magnitude(double x, double y)
    {
        
        return Math.Sqrt(Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2));
    }

    /* Use the XML documentation below to create the following methods:
        - Constructor(double x, double y)
        - Add(Vector other)
        - Subtract(Vector other)
    */

    /// <summary>
    /// Creates a new vector with the given X and Y components
    /// </summary>
    /// <param name="x">(double) The X component of the vector</param>
    /// <param name="y">(double) The Y component of the vector</param>
    public Vector (double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    /// <summary>
    /// Adds the given vector to this vector to create a new vector
    /// </summary>
    /// <param name="other">(Vector) The vector to add to this vector</param>
    /// <returns>(Vector) The sum of the two vectors</returns>
    private Vector AddVector (Vector v)
    {
        this.x += v.x;
        this.y += v.y;
        return this;
    }

    /// <summary>
    /// Subtracts the given vector from this vector to create a new vector
    /// </summary>
    /// <param name="other">(Vector) The vector to subtract from this vector</param>
    /// <returns>(Vector) This vector after the subtraction</returns>
    private Vector SubtractVector (Vector v)
    {
        this.x -= v.x;
        this.y -= v.y;
        return this;
    }

    /* The following method is provided for you. Do not modify it.*/

    /// <summary>
    /// Attempts to parse the given string into a vector
    /// </summary>
    /// <param name="input">(string) The string to parse</param>
    /// <param name="result">(out Vector?) The parsed vector, or null if the string was invalid</param>
    /// <returns>(bool) True if the string was parsed successfully, false otherwise</returns>
    /// <remarks>
    /// The string should be in the format "X,Y" where X and Y are doubles
    /// </remarks>
    public static bool TryParse(string? input, out Vector? result)
    {
        result = null;
        if (input == null) return false;
        string[] parts = input!.Split(',');
        if (parts.Length != 2) return false;
        if (!double.TryParse(parts[0], out double x)) return false;
        if (!double.TryParse(parts[1], out double y)) return false;
        result = new Vector(x, y);
        return true;
    }
}