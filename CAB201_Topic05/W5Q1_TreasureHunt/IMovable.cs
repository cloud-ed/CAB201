using System.Data;

namespace TreasureHunt;
/// <summary>
/// Represents an object that can be moved around in 2D space
/// </summary>
interface IMovable
{
    /* Use the XML documentation below to create the following properties:
        - Position (Vector), publicly gettable
        - Velocity (Vector), publicly gettable and settable
       And the following method:
        - void Move()
    */

    /// <summary>
    /// The position of the movable object (read-only)
    /// </summary>
    Vector position { get; }

    /// <summary>
    /// The velocity of the movable object (read-write)
    /// </summary>
    Vector velocity { get; set; }

    /// <summary>
    /// Moves the object according to its velocity
    /// </summary>
    /// <remarks>
    /// The object's position should be updated by adding its velocity to its position
    /// </remarks>
    public Vector Move(Vector position, Vector velocity);
}