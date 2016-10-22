namespace _08.CenterPoint
{
    using System;
    public struct Point
    {
        public double X;
        public double Y;
    }

    public class CenterPoint
    {
        static void Main()
        {
            Point pointOne;
            Point pointTwo;

            pointOne.X = double.Parse(Console.ReadLine());
            pointOne.Y = double.Parse(Console.ReadLine());
            pointTwo.X = double.Parse(Console.ReadLine());
            pointTwo.Y = double.Parse(Console.ReadLine());

            Point nearestToCenter = GetPointNearCenterPoint(pointOne, pointTwo);
            Console.WriteLine($"({nearestToCenter.X}, {nearestToCenter.Y})");
        }

        public static Point GetPointNearCenterPoint(Point first, Point second)
        {
            double firstDiagonal = Math.Sqrt(Math.Pow(first.X, 2) + Math.Pow(first.Y, 2));
            double secondDiagonal = Math.Sqrt(Math.Pow(second.X, 2) + Math.Pow(second.Y, 2));

            if (firstDiagonal <= secondDiagonal)
            {
                return first;
            }

            return second;
        }
    }
}
