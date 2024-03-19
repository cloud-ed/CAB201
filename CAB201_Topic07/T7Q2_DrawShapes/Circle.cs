namespace DrawShapes;
class Circle : Shape2D
{
    public double Radius { get; private set; }

    public Circle(Point2D centre, double radius) : base(centre)
    {
        Radius = radius;
    }

    public override double Area
    {
        get
        {
            return Math.PI * Radius * Radius;
        }
    }

    public override double Perimeter
    {
        get
        {
            return 2 * Math.PI * Radius;
        }
    }

    public override bool ContainsPoint(Point2D point)
    {
        return centre.DistanceTo(point) <= Radius - 0.5;
    }

    public override Point2D[] GetVertices()
    {
        return new Point2D[] { };
    }
}