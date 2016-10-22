namespace _06.ReverseArrayOfStrings
{
    using System;

    public class ReverseArrayOfStrings
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            Array.Reverse(input);
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
