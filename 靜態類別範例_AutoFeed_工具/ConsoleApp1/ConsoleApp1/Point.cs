namespace ConsoleApp1;

public class Point
{
    public double X;
    public double Y;
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);

    public static Point operator -(Point a, Point b) => new Point(a.X - b.X, a.Y - b.Y);

    public static bool operator ==(Point a, Point b) => a.X == b.X && a.Y == b.Y;
    public static bool operator !=(Point a, Point b) => !(a == b);
    public override string? ToString()
    {
        return $"({X},{Y})";
    }
}
