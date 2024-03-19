namespace GrowingSphere;
/// <summary>
/// A 3D shape that can grow
/// </summary>
interface IGrowable
{
    /* Use the XML documentation below to create the following properties:
        - GrowthRate (double), publicly gettable and settable
        - Volume (double), publicly gettable
       And the following method:
        - void Grow()
    */

    /// <summary>
    /// The rate at which the shape grows
    /// </summary>
    public double GrowthRate { get; set; }

    /// <summary>
    /// The current volume of the shape
    /// </summary>
    public double Volume { get; }

    /// <summary>
    /// Increases the size of the shape by the growth rate multiplicatively
    /// </summary>
    public void Grow();
}