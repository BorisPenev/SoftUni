namespace _06.PrimesChecker
{
    using System;

    public class PrimesChecker
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(number));
        }

        public static bool IsPrime(ulong number)
        {
            bool isPrime = true;
            if (number <= 1) isPrime = false;
            if (number == 2) isPrime = true;

            for (ulong divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0) 
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
