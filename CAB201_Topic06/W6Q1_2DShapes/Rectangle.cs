namespace Shapes2D;
class Rectangle : Shape2D
{
    // Insert your solution here
    public double Width { get; private set; }
    public double Height { get; private set; }
    public override double Area { get { return Width* Height; } }
    public override double Perimeter { get { return 2 * (Width + Height); } }

    public Rectangle(Point2D point, double width, double height) : base(point)
    {
        Width = width;
        Height = height;
    }

    public override bool ContainsPoint(Point2D point)
    {
        return (point.X >= centre.X - Width / 2 && point.X <= centre.X + Width / 2 && point.Y >= centre.Y - Height / 2 && point.Y <= centre.Y + Height / 2);
    }

    public override Point2D[] GetVertices()
    {
        Point2D[] vertices =
        {
            new Point2D(centre.X - Width / 2, centre.Y + Height / 2),
            new Point2D(centre.X + Width / 2, centre.Y + Height / 2),
            new Point2D(centre.X - Width / 2, centre.Y - Height / 2),
            new Point2D(centre.X + Width / 2, centre.Y - Height / 2)
        };
        return vertices;
    }
}   