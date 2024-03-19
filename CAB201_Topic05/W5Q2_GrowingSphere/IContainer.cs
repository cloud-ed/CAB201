namespace GrowingSphere;
/// <summary>
/// A 3D shape that can contain a point
/// </summary>
interface IContainer
{
    /* Use the XML documentation below to create the following method:
        - bool ContainsPoint(Point point)
    */

    /// <summary>
    /// Returns true if the given point is inside the shape
    /// </summary>
    public bool ContainsPoint (Point point);
}