using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            bool isInPrecisionMargin = false;

            double diff = Math.Abs(firstNumber - secondNumber);

            if (diff < 0.000001)
            {
                isInPrecisionMargin = true;
            }

            Console.WriteLine(isInPrecisionMargin);
        }
    }
}
