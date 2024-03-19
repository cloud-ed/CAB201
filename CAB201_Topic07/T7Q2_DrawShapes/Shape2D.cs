namespace DrawShapes;
abstract class Shape2D : IDrawable
{
    protected Point2D centre;
    public abstract double Area { get; }
    public abstract double Perimeter { get; }

    public Shape2D(Point2D centre)
    {
        this.centre = centre;
    }

    public void Translate(double dx, double dy)
    {
        centre.Translate(dx, dy);
    }

    public abstract bool ContainsPoint(Point2D point);

    public abstract Point2D[] GetVertices();

    public void Draw(Canvas canvas)
    {
        for (double x = canvas.BottomLeft.X; x < canvas.BottomLeft.X + canvas.Size; x++)
        {
            for (double y = canvas.BottomLeft.Y; y < canvas.BottomLeft.Y + canvas.Size; y++)
            {
                Point2D point = new Point2D(x, y);
                if (ContainsPoint(point)) canvas.PlotPoint(point);
            }
        }
    }
}