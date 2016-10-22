namespace _13.Factorial
{
    using System;
    using System.Numerics;

    public class Factorial
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFactorial(number));
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
