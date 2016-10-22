using System;

namespace _05.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(triangleBase, triangleHeight);

            Console.WriteLine(area);

        }

        public static double GetTriangleArea(double baseSize, double height)
        {
            return (baseSize * height) / 2.0;
        }
    }
}
