namespace _01_CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            foreach (double num in numbers)
            {
                if (!numbersCount.ContainsKey(num))
                {
                    numbersCount.Add(num, 1);
                }
                else
                {
                    numbersCount[num] += 1;
                }
            }

            foreach (var item in numbersCount)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

        }
    }
}
