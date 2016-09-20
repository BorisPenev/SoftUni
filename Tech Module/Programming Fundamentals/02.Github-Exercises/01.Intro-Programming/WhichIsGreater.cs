using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Intro_Programming
{
    class WhichIsGreater
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("X: {0} is greater", x);
            }
            else
            {
                Console.WriteLine("Y: {0} is greater", y);
            }

        }
    }
}
