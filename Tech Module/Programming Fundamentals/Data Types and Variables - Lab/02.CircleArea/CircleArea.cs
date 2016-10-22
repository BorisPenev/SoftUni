using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a circle radius: ");
            double radius = double.Parse(Console.ReadLine());
            decimal circleArea = (decimal)( Math.PI * radius * radius);

            Console.WriteLine("Circle Area = {0:F12}", circleArea);
        }
    }
}
