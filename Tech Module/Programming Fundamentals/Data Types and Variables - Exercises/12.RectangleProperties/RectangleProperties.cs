using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RectangleProperties
{
    class RectangleProperties
    {
        static double rectagleHeight;
        static double rectagleWidth;

        static void Main(string[] args)
        {
            rectagleHeight = double.Parse(Console.ReadLine());
            rectagleWidth = double.Parse(Console.ReadLine());

            Console.WriteLine(GetRectanglePerimeter());
            Console.WriteLine(GetRectangleArea());
            Console.WriteLine(GetRectangleDiameter());
        }

        public static double GetRectangleArea()
        {
            return rectagleHeight * rectagleWidth;
        }

        public static double GetRectanglePerimeter()
        {
            return (2 * rectagleHeight + 2 * rectagleWidth);
        }
        public static double GetRectangleDiameter()
        {
            return Math.Sqrt(Math.Pow(rectagleHeight,2) + Math.Pow(rectagleWidth, 2));
        }
    }
}
