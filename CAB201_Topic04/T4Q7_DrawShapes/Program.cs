namespace DrawShapes;
class Program
{
    public static void Main(string[] args)
    {
        // Keep the following lines intact
        Console.WriteLine("===========================");
        IDrawable square, circle;

        // Insert your solution here
        // Read the canvas size with ReadCanvasSize()
        int canvasSize = ReadCanvasSize();

        // Create a new canvas with the size read from the user
        Canvas canvas = new Canvas(canvasSize);

        // Read the square x, y, and side length with ReadSquareProperties()
        ReadSquareProperties(canvas, out int squareX, out int squareY, out int squareSize);

        // Read the circle x, y, and radius with ReadCircleProperties()
        ReadCircleProperties(canvas, out int circleX, out int circleY, out int radius);

        // Create a new square with the x, y, and side length above
        square = new Square(squareX, squareY, squareSize);

        // Create a new circle with the x, y, and radius above
        circle = new Circle(circleX, circleY, radius);

        // Draw the square and circle on the canvas using their Draw() methods
        square.Draw(canvas);
        circle.Draw(canvas);

        // Keep the following lines intact
        canvas.Display();
        Console.WriteLine("===========================");
    }

    public static void ReadSquareProperties(Canvas canvas, out int x, out int y, out int size)
    {
        // Insert your solution here
        Utils.ReadPosition("Enter the position of the square in the form x,y: ", canvas, out x, out y);
        Utils.ReadNonNegativeInteger("Enter the side length of the square: ", out size);
    }

    public static void ReadCircleProperties(Canvas canvas, out int x, out int y, out int radius)
    {
        // Insert your solution here
        Utils.ReadPosition("Enter the position of the circle in the form x,y: ", canvas, out x, out y);
        Utils.ReadNonNegativeInteger("Enter the radius of the circle: ", out radius);
    }

    public static int ReadCanvasSize()
    {
        Console.WriteLine("Enter the canvas size: ");
        int canvasSize;
        while (!int.TryParse(Console.ReadLine(), out canvasSize) || canvasSize <= 0)
        {
            Console.WriteLine("Invalid input. The canvas size must be a positive integer.");
            Console.WriteLine("Enter the canvas size: ");
        }
        return canvasSize;
    }
}