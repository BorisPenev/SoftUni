namespace _03_CirclesIntersection
{
    using System;
    using System.Linq;

    public class CirclesIntersection
    {
        static void Main()
        {
            int[] c1Input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] c2Input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Circle c1 = new Circle() { Center = new Point() { X = c1Input[0], Y = c1Input[1]}, Radius = c1Input[2] };
            Circle c2 = new Circle() { Center = new Point() { X = c2Input[0], Y = c2Input[1] }, Radius = c2Input[2] };

            bool areCirclesIntersecting = Intersect(c1, c2);

            Console.WriteLine(areCirclesIntersecting ? "Yes": "No");
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            bool areIntersecting = false;
            double distance = Math.Sqrt(
                Math.Pow(c2.Center.X - c1.Center.X, 2)
                + Math.Pow(c2.Center.Y - c1.Center.Y, 2));

            if (distance <= c1.Radius + c2.Radius)
            {
                areIntersecting = true;
            }

            return areIntersecting;
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
    }
}
