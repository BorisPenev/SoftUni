using System;

namespace _06.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double numberRaisedToPower = RaiseToPower(number, power);

            Console.WriteLine(numberRaisedToPower);
        }

        public static double RaiseToPower(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
