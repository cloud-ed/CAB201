namespace TreasureHunt;
/// <summary>
/// A treasure hunter that can move around the map, and can be located in 2D space
/// </summary>
class Hunter : IMovable
{
    /* Implement the IMovable interface here. Note that the Position property should
    be publicly gettable, but needs to be privately settable. */
    public Vector position { get; private set; }
    public Vector velocity { get; set; }

    /* Use the XML documentation below to create a constructor */

    /// <summary>
    /// Creates a new hunter at the given position. The hunter's velocity is initially zero in both directions.
    /// </summary>
    /// <param name="position">(Vector) The initial position of the hunter</param>
    public Hunter(Vector position)
    {
        this.position = position;
        velocity = new Vector(0, 0);
    }

    public Vector Move(Vector position, Vector velocity)
    {
        position.x += velocity.x;
        position.y += velocity.y;
        return position;
    }
}