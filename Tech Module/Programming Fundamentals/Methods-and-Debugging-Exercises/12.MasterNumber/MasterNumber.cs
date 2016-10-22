namespace _12.MasterNumber
{
    using System;
    using System.Collections.Generic;

    public class MasterNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            foreach (var item in GetMasterNumbers(number))
            {
                Console.WriteLine($"{item}");
            }
        }

        public static List<int> GetMasterNumbers(int num)
        {
            List<int> listOfMasterNumbers = new List<int>();

            for (int i = 1; i < num; i++)
            {
                if (IsPalindrome(i) && ContainsEvenDigit(i) && SumOfDigits(i) % 7 == 0)
                {
                    listOfMasterNumbers.Add(i);
                }
            }

            return listOfMasterNumbers;
        }

        public static bool IsPalindrome(int num)
        {
            string numberAsString = num.ToString();
            bool isPalindrome = false;

            if (numberAsString.Length == 1)
            {
                isPalindrome = true;
                return isPalindrome;
            }

            for (int i = 0,  j = numberAsString.Length - 1; i < numberAsString.Length / 2; i++, j--)
            {
                if (numberAsString[i] != numberAsString[j])
                {
                    isPalindrome = false;
                    break;
                }
                else
                {
                    isPalindrome = true;
                }
            }

            return isPalindrome;
        }

        public static long SumOfDigits(int num)
        {
            string numberAsString = num.ToString();
            long sum = 0L;

            foreach (char digit in numberAsString)
            {
                sum += int.Parse(digit.ToString());
            }

            return sum;
        }

        public static bool ContainsEvenDigit(int num)
        {
            string numberAsString = num.ToString();
            bool containsEvenDigit = false;

            foreach (char digit in numberAsString)
            {
                if (int.Parse(digit.ToString()) % 2 == 0 )
                {
                    containsEvenDigit = true;
                    break;
                }
            }

            return containsEvenDigit;
        }
    }
}
