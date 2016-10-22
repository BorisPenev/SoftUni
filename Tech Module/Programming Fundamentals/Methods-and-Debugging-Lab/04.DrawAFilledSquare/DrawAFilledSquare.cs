using System;

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int squareSize = int.Parse(Console.ReadLine());
            PrintSquare(squareSize);
        }

        public static void PrintFirstOrLastLine(int squareSize)
        {
            Console.WriteLine("{0}", new string('-', 2 * squareSize));
        }
        public static void PrintMiddleLine(int squareSize)
        {
            Console.Write("-");
            for (int i = 1; i < squareSize; i++)
            {
                Console.Write(@"\/");
            }
            Console.Write("-");
            Console.WriteLine();
        }
        public static void PrintSquare(int squareSize)
        {
            PrintFirstOrLastLine(squareSize);
            for (int i = 0; i < squareSize - 2; i++)
            {
                PrintMiddleLine(squareSize);
            }           
            PrintFirstOrLastLine(squareSize);

        }
    }
}
