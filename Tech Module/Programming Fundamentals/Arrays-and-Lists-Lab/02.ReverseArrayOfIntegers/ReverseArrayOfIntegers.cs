namespace _02.ReverseArrayOfIntegers
{
    using System;

    public class ReverseArrayOfIntegers
    {
        static void Main()
        {
            int numberOfInts = int.Parse(Console.ReadLine());
            int[] arrayOfInts = new int[numberOfInts];

            for (int i = 0; i < numberOfInts; i++)
            {
                arrayOfInts[i] = int.Parse(Console.ReadLine());
            }

            for (int i = arrayOfInts.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", arrayOfInts[i]);
            }
        }
    }
}
