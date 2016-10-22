namespace _14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class FactorialTrailingZeroes
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string factorialAsString = GetFactorial(number).ToString();

            Console.WriteLine($"{GetFactorialTrailingZeros(factorialAsString)}");
        }

        public static int GetFactorialTrailingZeros(string factorialAsString)
        {
            int zeroes = 0;

            for (int index = factorialAsString.Length - 1; index > 0 ; index--)
            {
                if (factorialAsString[index] == '0')
                {
                    zeroes++;
                }
                else
                {
                    break;
                }
            }

            return zeroes;
        }

        public static BigInteger GetFactorial(int number)
        {
            BigInteger factorial = 1;

            for (BigInteger i = 1; i <= number; i++)
            {
                factorial = BigInteger.Multiply(factorial, i);
            }

            return factorial;
        }
    }
}
