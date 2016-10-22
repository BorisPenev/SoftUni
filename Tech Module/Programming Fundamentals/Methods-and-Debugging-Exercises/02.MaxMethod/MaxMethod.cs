namespace _02.MaxMethod
{
    using System;

    public class MaxMethod
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int max = GetMax(firstNumber, secondNumber);
            max = GetMax(max, thirdNumber);

            Console.WriteLine(max);
        }

        public static int GetMax(int firstNumber, int SecondNumber)
        {
            if (firstNumber >= SecondNumber)
            {
                return firstNumber;
            }
            else
            {
                return SecondNumber;
            }
        }
    }
}
