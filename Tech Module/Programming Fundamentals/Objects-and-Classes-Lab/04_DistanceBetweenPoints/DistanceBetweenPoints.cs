namespace _04_DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        static void Main()
        {
            int[] lineOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] lineTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point p1 = new Point();
            Point p2 = new Point();
            p1.X = lineOne[0];
            p1.Y = lineOne[1];
            p2.X = lineTwo[0];
            p2.Y = lineTwo[1];

            Console.WriteLine(Math.Round(Point.GetDistance(p1, p2), 3));
        }
    }
}
