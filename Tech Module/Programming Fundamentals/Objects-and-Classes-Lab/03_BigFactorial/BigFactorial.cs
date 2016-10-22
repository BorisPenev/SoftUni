namespace _03_BigFactorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
         

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = BigInteger.Multiply(factorial, i);
            }

            Console.WriteLine(factorial);
        }
    }
}
