namespace _10.CubeProperties
{
    using System;

    public class CubeProperties
    {
        static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();

            //face, space, volume or area
            if (property.Equals("face"))
            {
                Console.WriteLine("{0:F2}", GetFaceDiagonal(cubeSide));
            }
            else if (property.Equals("space"))
            {
                Console.WriteLine("{0:F2}", GetSpaceDiagonal(cubeSide));
            }
            else if (property.Equals("volume"))
            {
                Console.WriteLine("{0:F2}", GetVolume(cubeSide));
            }
            else
            {
                Console.WriteLine("{0:F2}", GetSurfaceArea(cubeSide));
            }
        }

        public static double GetFaceDiagonal(double side)
        {
            return Math.Sqrt(2 * side * side);
        }

        public static double GetSpaceDiagonal(double side)
        {
            return Math.Sqrt(3 * side * side);
        }

        public static double GetVolume(double side)
        {
            return Math.Pow(side, 3);
        }

        public static double GetSurfaceArea(double side)
        {
            return 6 * Math.Pow(side, 2);
        }
    }
}
