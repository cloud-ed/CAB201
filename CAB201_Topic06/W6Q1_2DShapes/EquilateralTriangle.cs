namespace Shapes2D;
class EquilateralTriangle : Shape2D
{
    // Insert your solution here
    public double SideLength { get; private set; }
    public override double Area { get { return Math.Sqrt(3) / 4 * SideLength * SideLength; } }
    public override double Perimeter { get { return 3 * SideLength; } }

    public EquilateralTriangle(Point2D point, double sidelength) : base(point)
    {
        this.SideLength = sidelength;
    }

    public override bool ContainsPoint(Point2D point)
    {
        double dy = point.Y - centre.Y;
        double dx = point.X - centre.X;
        return (dy <= Math.Sqrt(3) * (dx + SideLength / 3) && dy <= -Math.Sqrt(3) * (dx - SideLength / 3) && dy >= -Math.Sqrt(3) / 6 * SideLength);
    }

    public override Point2D[] GetVertices()
    {
        Point2D[] vertices =
        {
            new Point2D(centre.X, centre.Y + Math.Sqrt(3) / 3 * SideLength),
            new Point2D(centre.X - SideLength / 2, centre.Y - Math.Sqrt(3) / 6 * SideLength),
            new Point2D(centre.X + SideLength / 2, centre.Y - Math.Sqrt(3) / 6 * SideLength)
        };
        return vertices;
    }
}