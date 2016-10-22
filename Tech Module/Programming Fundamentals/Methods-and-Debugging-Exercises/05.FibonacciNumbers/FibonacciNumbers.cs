namespace _05.FibonacciNumbers
{
    using System;

    public class FibonacciNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacciNumber(number));
        }

        public static int GetFibonacciNumber(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b;
        }
    }
}
