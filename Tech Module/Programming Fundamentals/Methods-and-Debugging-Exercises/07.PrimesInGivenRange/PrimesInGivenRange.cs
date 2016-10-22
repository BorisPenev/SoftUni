namespace _07.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class PrimesInGivenRange
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> listOfPrimes = GetPrimesInRange(startNum, endNum);

            PrintPrimes(listOfPrimes);
        }

        public static void PrintPrimes(List<int> listOfPrimes)
        {
            if (listOfPrimes.Count != 0)
            {
                for (int index = 0; index < listOfPrimes.Count; index++)
                {
                    if (index != listOfPrimes.Count - 1)
                    {
                        Console.Write($"{listOfPrimes[index]}, ");
                    }
                    else
                    {
                        Console.Write($"{listOfPrimes[index]} ");
                    }
                }
            }
            else
            {
                Console.WriteLine("(empty list)");
            }
            
        }
        public static List<int> GetPrimesInRange(int start, int end)
        {
            List<int> listOfPrimes = new List<int>();
            for (int number = start; number <= end; number++)
            {
                if (IsPrime(number))
                {
                    listOfPrimes.Add(number);
                }
            }

            return listOfPrimes;
        }

        public static bool IsPrime(int number)
        {
            bool isPrime = true;
            if (number <= 1) isPrime = false;
            if (number == 2) isPrime = true;

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
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
