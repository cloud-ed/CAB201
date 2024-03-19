using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace GrowingSphere;
/// <summary>
/// Represents a point in 3D space
/// </summary>
class Point
{
    /* Use the XML documentation below to create the following properties:
        - X (double), auto-implemented, publicly gettable and settable
        - Y (double), auto-implemented, publicly gettable and settable
        - Z (double), auto-implemented, publicly gettable and settable
    */
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }


    /* Use the XML documentation below to create the following methods:
        - Constructor(double x, double y, double z)
        - static bool TryParse(string input, out Point? point)
    */

    /// <summary>
    /// Creates a new point with the given X, Y and Z coordinates
    /// </summary>
    /// <param name="x">(double) The X coordinate of the point</param>
    /// <param name="y">(double) The Y coordinate of the point</param>
    /// <param name="z">(double) The Z coordinate of the point</param> 
    public Point(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    /// <summary>
    /// Attempts to parse the given string into a point
    /// </summary>
    /// <param name="input">(string) The string to parse</param>
    /// <param name="point">(Point?) The point that was parsed, or null if the parse failed</param>
    /// <returns>(bool) True if the parse succeeded, false otherwise</returns>
    public static bool TryParse(string input, out Point? point)
    {
        point = null;
        if (input == null) return false;
        string[] pos = input.Split(',');
        if (pos.Length != 3) { return false; }
        if (!double.TryParse(pos[0].Trim(), out double x)) return false;
        if (!double.TryParse(pos[1].Trim(), out double y)) return false;
        if (!double.TryParse(pos[2].Trim(), out double z)) return false;
        point = new Point(x, y, z);
        return true;
    }
}