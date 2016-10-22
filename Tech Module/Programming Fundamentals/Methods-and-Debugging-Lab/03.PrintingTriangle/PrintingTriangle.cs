using System;

namespace _03.PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int triangleSize = int.Parse(Console.ReadLine());
            PrintUpperHalf(triangleSize);
            PrintBottomHalf(triangleSize);
        }

        public static void PrintUpperHalf(int triangleSize)
        {
            for (int i = 0; i < triangleSize; i++)
            {
                PrintLine(1, i);
            }
        }

        public static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void PrintBottomHalf(int triangleSize)
        {
            for (int i = triangleSize; i > 0 ; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
