namespace _09.LongerLine
{
    using System;

    public struct Point
    {
        public double X;
        public double Y;
    }

    public struct Line
    {
        public Point startPoint;
        public Point endPoint;

        public double GetLineLenght()
        {
            double sideXLenght = Math.Abs(startPoint.X) + Math.Abs(endPoint.X);
            double sideYLenght = Math.Abs(startPoint.Y) + Math.Abs(endPoint.Y);

            return Math.Sqrt(Math.Pow(sideXLenght, 2) + Math.Pow(sideYLenght, 2));
        }
    }

    public class LongerLine
    {
        static void Main()
        {
            Line firstLine;
            Line secondLine;

            firstLine.startPoint.X = double.Parse(Console.ReadLine());
            firstLine.startPoint.Y = double.Parse(Console.ReadLine());
            firstLine.endPoint.X = double.Parse(Console.ReadLine());
            firstLine.endPoint.Y = double.Parse(Console.ReadLine());
            secondLine.startPoint.X = double.Parse(Console.ReadLine());
            secondLine.startPoint.Y = double.Parse(Console.ReadLine());
            secondLine.endPoint.X = double.Parse(Console.ReadLine());
            secondLine.endPoint.Y = double.Parse(Console.ReadLine());

            Line longestLine = GetLongerLine(firstLine, secondLine);
            Point nearestToCenter = GetPointNearCenterPoint(longestLine.startPoint, longestLine.endPoint);

            if (nearestToCenter.X == longestLine.startPoint.X && nearestToCenter.Y == longestLine.startPoint.Y)
            {
                Console.WriteLine("({0}, {1})({2}, {3})",
                    nearestToCenter.X, nearestToCenter.Y,
                    longestLine.endPoint.X, longestLine.endPoint.Y);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})",
                    nearestToCenter.X, nearestToCenter.Y,
                    longestLine.startPoint.X, longestLine.startPoint.Y);
            }            
        }

        public static Line GetLongerLine(Line firstLine, Line secondLine)
        {
            if (firstLine.GetLineLenght() >= secondLine.GetLineLenght())
            {
                return firstLine;
            }
            else
            {
                return secondLine;
            }
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
