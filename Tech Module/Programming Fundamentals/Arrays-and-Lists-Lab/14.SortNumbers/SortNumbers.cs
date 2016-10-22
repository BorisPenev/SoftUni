namespace _14.SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortNumbers
    {
        static void Main()
        {
            List<double> arr = new List<double>(Console.ReadLine().Split(' ').Select(double.Parse).ToArray());
            arr.Sort();

            Console.WriteLine(string.Join(" <= ", arr));
        }
    }
}
