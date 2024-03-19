namespace Shapes2D;
abstract class Shape2D
{
    // Insert your solution here
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
}