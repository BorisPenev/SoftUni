using System;

namespace _03.ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            // decimal sum = 0.0000m;   <---- This will always display at least this much symbols after the decimal dot EVEN when adding integer numbers 
            decimal number = 0;

            for (int i = 0; i < n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum += number;
            }            
            
            Console.WriteLine("{0}",sum);
        }
    }
}
