using System.ComponentModel;

namespace GrowingSphere;
/// <summary>
/// A 3D sphere that can grow
/// </summary>
class Sphere : IContainer, IGrowable
{
    /* Create two private fields:
        - centre (Point)
        - radius (double)
    */
    private Point centre;
    private double radius;

    /* Implement the properties and methods from the interfaces, noting that:
        - The sphere's volume is 4/3 * pi * r^3, where r is the sphere's radius
        - The sphere contains a point (x,y,z) if (x - x0)^2 + (y - y0)^2 + (z - z0)^2 <= r^2, where
            - (x0, y0, z0) is the sphere's centre
            - r is the sphere's radius
        - When the sphere grows, multiply its radius by the growth rate
    */
    public double GrowthRate { get; set; }
    public double Volume { get { return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3); } }

    public bool ContainsPoint(Point point)
    {
        return (Math.Pow((point.X - centre.X), 2) + Math.Pow((point.Y - centre.Y), 2) + Math.Pow((point.Z - centre.Z), 2) <= Math.Pow(radius, 2));
    }

    public void Grow()
    {
        radius *= GrowthRate;
    }

    /* Use the XML documentation below to create the following constructor:
        - Sphere(Point centre, double radius)
    */

    /// <summary>
    /// Creates a new sphere with the given centre and radius
    /// </summary>
    /// <param name="centre">The centre of the sphere</param>
    /// <param name="radius">The radius of the sphere</param>
    public Sphere(Point centre, double radius)
    {
        this.centre = centre;
        this.radius = radius;
        GrowthRate = 0;
    }
}