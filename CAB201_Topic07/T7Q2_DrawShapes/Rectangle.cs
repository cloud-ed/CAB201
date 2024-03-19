namespace DrawShapes;
class Rectangle : Shape2D
{
    public double Width { get; private set; }
    public double Height { get; private set; }
    public Rectangle(Point2D centre, double width, double heigh) : base(centre)
    {
        Width = width;
        Height = heigh;
    }
    public override double Area
    {
        get
        {
            return Width * Height;
        }
    }
    public override double Perimeter
    {
        get
        {
            return 2 * (Width + Height);
        }
    }

    public override bool ContainsPoint(Point2D point)
    {
        return point.X >= centre.X - Width / 2
            && point.X <= centre.X + Width / 2
            && point.Y >= centre.Y - Height / 2
            && point.Y <= centre.Y + Height / 2;
    }
    public override Point2D[] GetVertices()
    {
        return new Point2D[] {
            new Point2D(centre.X - Width / 2, centre.Y + Height / 2),
            new Point2D(centre.X + Width / 2, centre.Y + Height / 2),
            new Point2D(centre.X - Width / 2, centre.Y - Height / 2),
            new Point2D(centre.X + Width / 2, centre.Y - Height / 2)
        };
    }
}