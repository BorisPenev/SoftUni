namespace _05.RoundingNumbers
{
    using System;

    public class RoundingNumbers
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] arr = new double[input.Length];
            double[] roundedNumbers = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = double.Parse(input[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                roundedNumbers[i] = Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", arr[i], roundedNumbers[i]);
            }
            
        }
    }
}
