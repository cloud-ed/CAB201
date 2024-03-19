using System.Security.Cryptography;

namespace Triangles;
class Triangle
{
    // Insert your solution here
    private double side1;
    private double side2;
    private double side3;

    /// <summary>
    /// Equilateral triangle
    /// </summary>
    /// <param name="side1"></param>
    public Triangle(double side1)
    {
        this.side1 = side1;
        side2 = side1;
        side3 = side1;
        return;
    }

    /// <summary>
    /// Isosceles triangle
    /// </summary>
    /// <param name="side1"></param>
    /// <param name="side2"></param>
    public Triangle(double baseSide, double height)
    {
        side1 = baseSide;
        side2 = Math.Sqrt(Math.Pow(height, 2) + Math.Pow((baseSide / 2), 2));
        side3 = side2;
        return;
    }

    /// <summary>
    /// Scalene triangle
    /// </summary>
    /// <param name="side1"></param>
    /// <param name="side2"></param>
    /// <param name="side3"></param>
    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
        return;
    }
    
    public string GetType()
    {
        if (side1 == -1 || side2 == -1 || side3 == -1) return "Invalid";
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side2 == side3 || side3 == side1)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
    
    public double GetArea()
    {
        if (side1 == -1 || side2 == -1 || side3 == -1) return -1;
        if (side1 == 0 || side2  == 0 || side3 == 0)
        {
            return 0;
        }
        double s = (side1 + side2 + side3) / 2;
        double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        return Math.Round(area, 2);
    }
}