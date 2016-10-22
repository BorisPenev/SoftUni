namespace _06_RectanglePosition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RectanglePosition
    {
        static void Main()
        {
            List<int> firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Rectangle r1 = new Rectangle(firstLine[0], firstLine[1], firstLine[2], firstLine[3]);
            Rectangle r2 = new Rectangle(secondLine[0], secondLine[1], secondLine[2], secondLine[3]);
            bool isFirstInSecond = r1.IsInside(r2);

            Console.WriteLine(isFirstInSecond ? "Inside": "Not inside");
        }
    }

    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }       
        public int Right
        {
            get
            {                 
                if (this.Left < 0)
                {
                    return this.Left + (-1)*this.Width;
                }

                return this.Left + this.Width;
            }
        }
        public int Bottom
        {
            get
            {
                if (this.Top < 0)
                {
                    return this.Top + (-1) * this.Height;
                }

                return this.Top + this.Height;
            }
        }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {

        }
        public Rectangle(int left, int top, int width, int height)
        {
            this.Left = left;
            this.Top = top;
            this.Width = width;
            this.Height = height;
        }

        public bool IsInside(Rectangle r)
        {
            bool isInside = false;

            //o r1.Left ≥ r2.Left
            //o   r1.Right ≤ r2.Right
            //o   r1.Top ≤ r2.Top
            //o   r1.Bottom ≤ r2.Bottom

            int r1Left = Math.Abs(this.Left);
            int r1Right = Math.Abs(this.Right);
            int r1Top = Math.Abs(this.Top);
            int r1Bottom = Math.Abs(this.Bottom);

            int r2Left = Math.Abs(r.Left);
            int r2Right = Math.Abs(r.Right);
            int r2Top = Math.Abs(r.Top);
            int r2Bottom = Math.Abs(r.Bottom);

            if (r1Left >= r2Left && r1Right <= r2Right && r1Top >= r2Top && r1Bottom <= r2Bottom)
            {
                isInside = true;
            }

            return isInside;
        }
    }
}
