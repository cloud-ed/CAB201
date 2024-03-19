namespace Shapes2D;
/// <summary>
/// A point in 2D space, where the x axis is horizontal, increasing to the right, and
/// the y axis is vertical, increasing upwards.
/// </summary>
class Point2D
{
    /// <summary>
    /// The x coordinate of the point.
    /// </summary>
    public double X { get; private set; }

    /// <summary>
    /// The y coordinate of the point.
    /// </summary>
    public double Y { get; private set; }

    /// <summary>
    /// Creates a new point at the given coordinates.
    /// </summary>
    /// <param name="x">The x coordinate of the point</param>
    /// <param name="y">The y coordinate of the point</param>
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }


    /// <summary>
    /// Moves the point by the given amount.
    /// </summary>
    /// <param name="dx">The amount to move the point in the x direction</param>
    /// <param name="dy">The amount to move the point in the y direction</param>
    public void Translate(double dx, double dy)
    {
        X += dx;
        Y += dy;
    }

    /// <summary>
    /// Calculates the distance between this point and another point.
    /// </summary>
    /// <param name="point">The other point</param>
    /// <returns>The distance between the two points</returns>
    /// <remarks>
    /// The distance between two points is calculated using Pythagoras' theorem.
    /// distance = sqrt((x2 - x1)^2 + (y2 - y1)^2)
    /// </remarks>
    public double DistanceTo(Point2D point)
    {
        double dx = X - point.X;
        double dy = Y - point.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    /// <summary>
    /// Returns a string representation of the point in the form (x, y)
    /// </summary>
    /// <returns>A string representation of the point</returns>
    public override string ToString()
    {
        return $"({X:0.00}, {Y:0.00})";
    }
}