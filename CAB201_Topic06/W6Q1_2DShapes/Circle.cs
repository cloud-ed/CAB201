using System.Security;

namespace Shapes2D;
class Circle : Shape2D
{
    // Insert your solution here
    public double Radius { get; private set; }
    public override double Area { get { return Math.PI * Radius * Radius; } }
    public override double Perimeter { get { return 2 * Math.PI * Radius; } }

    public Circle(Point2D point, double radius) : base(point)
    {
        this.Radius = radius;
    }

    public override bool ContainsPoint(Point2D point)
    {
        return (centre.DistanceTo(point) <= Radius);
    }

    public override Point2D[] GetVertices()
    {
        Point2D[] vertices = new Point2D[0];
        return vertices;
    }
}