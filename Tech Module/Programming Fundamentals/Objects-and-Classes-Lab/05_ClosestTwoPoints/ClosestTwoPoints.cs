namespace _05_ClosestTwoPoints
{
    using System;

    public class ClosestTwoPoints
    {
        static void Main()
        {
            Point[] points = Point.ReadPoints();
            Point[] closestPoints = Point.FindClosestTwoPoints(points);

            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);

        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        static void PrintDistance(Point[] points)
        {
            double distance = Point.GetDistance(points[0], points[1]);
            Console.WriteLine("{0:f3}", distance);
        }

    }
}
