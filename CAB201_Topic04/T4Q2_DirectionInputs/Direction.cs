using System.Reflection.Metadata.Ecma335;

namespace DirectionalInputs;
class Direction
{
    // Insert your solution here, using the XML comments provided as a guide.
    /// <summary>
    /// Parses the specified character and outputs the change in position.
    /// </summary>
    /// <param name="ch">The character to parse.</param>
    /// <param name="xDiff">The change in the horizontal (x) direction.</param>
    /// <param name="yDiff">The change in the vertical (y) direction.</param>
    /// <returns>True if the character is valid; otherwise, false.</returns>
    public static bool TryParse(char direction, out int xDiff, out int yDiff)
    {
        char[] compassDirections = new[] { 'N', 'S', 'E', 'W' };
        switch (char.ToUpper(direction))
        {
            case 'N': { xDiff = 0; yDiff = 1; return true; }
            case 'S': { xDiff = 0; yDiff = -1; return true; }
            case 'E': { xDiff = 1; yDiff = 0; return true; }
            case 'W': { xDiff = -1; yDiff = 0; return true; }
            default: { xDiff = 0; yDiff = 0; return false; }
        }
    }
}