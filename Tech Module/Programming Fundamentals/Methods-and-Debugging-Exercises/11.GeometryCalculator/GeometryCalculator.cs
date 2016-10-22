namespace _11.GeometryCalculator
{
    using System;

    public class _GeometryCalculator
    {
        static void Main()
        {
            string shapeType = Console.ReadLine().ToLower();
            double firstValue = double.Parse(Console.ReadLine());
            

            if (shapeType.Equals("square"))
            {
                Console.WriteLine("{0:f2}", GetSquareArea(firstValue));
            }
            else if (shapeType.Equals("triangle"))
            {
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetTriangleArea(firstValue, height));
            }
            else if (shapeType.Equals("circle"))
            {
                Console.WriteLine("{0:f2}",GetCirleArea(firstValue));
            }
            else
            {
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", GetRectangleArea(firstValue, height));
            }
        }
        public static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

        public static double GetTriangleArea(double side, double height)
        {
            return (side * height)/2;
        }

        public static double GetCirleArea(double radius)
        {
            return  Math.PI * radius * radius;
        }

        public static double GetSquareArea(double side)
        {
            return side * side;
        }
    }
}
