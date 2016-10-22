namespace _15.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        static void Main()
        {
            List<int> arr = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            List<int> sqareNumbers = new List<int>();

            foreach (int num in arr)
            {
                if (num % Math.Sqrt(num) == 0)
                {
                    sqareNumbers.Add(num);
                }
            }

            sqareNumbers.Sort((a,b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", sqareNumbers));
        }
    }
}
