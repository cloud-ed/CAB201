namespace DrawShapes;
/// <summary>
/// Represents a shape that can be drawn on a canvas.
/// </summary>
interface IDrawable
{
    /// <summary>
    /// Draws the shape on the canvas.
    /// </summary>
    /// <param name="canvas">The canvas to draw on.</param>
    void Draw(Canvas canvas);
}