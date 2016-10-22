namespace _04_SieveOfEratosthenes
{
    using System;

    public class SieveOfEratosthenes
    {
        static void Main()
        {
            long range = long.Parse(Console.ReadLine());
            bool[] primes = new bool[range + 1];
            for (long i = 2; i <= range; i++)
            {
                primes[i] = true;
            }

            for (long i = 2; i <= range; i++)
            {
                if (primes[i])
                {
                    Console.Write($"{i} ");

                    for (long j = i + i; j <= range; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }
        }
    }
}
