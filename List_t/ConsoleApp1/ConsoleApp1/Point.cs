namespace ZeroToMaster;

internal class Point
{
    double X;
    double Y;

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    // DistanceTo method
    public double DistanceTo(Point p)
    {
        return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
    }

    // operator overloading +, -, ==, !=

    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }

    public static bool operator ==(Point p1, Point p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }

    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1 == p2);
    }

    // override ToString method
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
