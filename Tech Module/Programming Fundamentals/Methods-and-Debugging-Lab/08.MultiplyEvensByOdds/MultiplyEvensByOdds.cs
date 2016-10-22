using System;

namespace _08.MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }

        public static int GetMultipleOfEvensAndOdds(int number)
        {
            int evenSum = GetEvenSumOfDigits(number);
            int oddSum = GetOddSumOfDigits(number);

            return evenSum * oddSum;
        }
        public static int GetEvenSumOfDigits(int number)
        {
            int sum = 0;

            while (Math.Abs(number) > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }

            return sum;
        }

        public static int GetOddSumOfDigits(int number)
        {
            int sum = 0;

            while (Math.Abs(number) > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }

            return sum;
        }
    }
}
