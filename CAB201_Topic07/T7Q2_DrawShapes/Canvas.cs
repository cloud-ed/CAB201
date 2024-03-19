namespace DrawShapes;
/// <summary>
/// Represents a pixel-based canvas where shapes can be drawn by plotting points.
/// </summary>
class Canvas
{
    private char[,] canvas;
    public int Size { get; private set; }

    public Point2D BottomLeft { get; private set; }

    private void ShiftCanvas(ref int x, ref int y)
    {
        x -= (int)Math.Round(BottomLeft.X);
        y -= (int)Math.Round(BottomLeft.Y);
    }

    /// <summary>
    /// Plots a point on the canvas at the given coordinates using the specified character.
    /// If a top left corner was specified, the coordinates are relative to that corner
    /// otherwise, the coordinates are relative to point (0, 0).
    /// </summary>
    /// <param name="point">The point to plot</param>
    /// <param name="c">(Optional) The character to plot. Defaults to '#'</param>
    public void PlotPoint(Point2D point, char c = '#')
    {
        PlotPoint((int)Math.Round(point.X), (int)Math.Round(point.Y), c);
    }

    /// <summary>
    /// Plots a point on the canvas at the given coordinates using the character '#'.
    /// If a top left corner was specified, the coordinates are relative to that corner
    /// otherwise, the coordinates are relative to point (0, 0).
    /// </summary>
    /// <param name="x">The x coordinate</param>
    /// <param name="y">The y coordinate</param>
    public void PlotPoint(int x, int y)
    {
        PlotPoint(x, y, '#');
    }

    /// <summary>
    /// Plots a point on the canvas at the given coordinates using the given character.
    /// If a top left corner was specified, the coordinates are relative to that corner
    /// otherwise, the coordinates are relative to point (0, 0).
    /// </summary>
    /// <param name="x">The x coordinate</param>
    /// <param name="y">The y coordinate</param>
    /// <param name="c">The character to plot</param>
    public void PlotPoint(int x, int y, char c)
    {
        ShiftCanvas(ref x, ref y);
        if (!ContainsPoint(x, y)) return;
        canvas[y, x] = c;
    }

    /// <summary>
    /// Creates a new canvas of the given size with the given top left corner.
    /// </summary>
    /// <param name="size">The size of the canvas</param>
    /// <param name="topLeft">The top left corner of the canvas</param>
    public Canvas(int size, Point2D topLeft) : this(size)
    {
        BottomLeft = topLeft;
    }

    /// <summary>
    /// Creates a new canvas of the given size with the given top left corner.
    /// </summary>
    /// <param name="size">The size of the canvas</param>
    /// <param name="topLeft">The top left corner of the canvas</param>
    public Canvas(int size)
    {
        canvas = new char[size, size];
        for (int y = 0; y < canvas.GetLength(0); y++)
        {
            for (int x = 0; x < canvas.GetLength(1); x++)
            {
                canvas[y, x] = '.';
            }
        }
        Size = size;
        BottomLeft = new Point2D(0, 0);
    }

    /// <summary>
    /// Checks if the given point is within the canvas.
    /// </summary>
    /// <param name="x">The x coordinate</param>
    /// <param name="y">The y coordinate</param>
    /// <returns>True if the point is within the canvas, false otherwise</returns>
    public bool ContainsPoint(int x, int y)
    {
        return x >= 0 && y >= 0 && x < canvas.GetLength(1) && y < canvas.GetLength(0);
    }

    /// <summary>
    /// Displays the canvas on the console.
    /// </summary>
    public void Display()
    {
        Console.WriteLine("The canvas looks like this:");
        Console.WriteLine(new string('-', canvas.GetLength(1)));
        for (int y = canvas.GetLength(0) - 1; y >= 0; y--)
        {
            for (int x = 0; x < canvas.GetLength(1); x++)
            {
                Console.Write(canvas[y, x]);
            }
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', canvas.GetLength(1)));
    }
}