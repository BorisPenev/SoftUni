namespace _04_DistanceBetweenPoints
{
    using System;

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static double GetDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }

    
}
