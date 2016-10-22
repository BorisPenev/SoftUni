namespace _16.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountNumbers
    {
        static void Main()
        {
            List<int> arr = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            Dictionary<int, int> numbersCounter = new Dictionary<int, int>();

            arr.Sort();
            
            foreach (int num in arr)
            {
                if (!numbersCounter.ContainsKey(num))
                {
                    numbersCounter.Add(num, 1);
                }
                else
                {
                    numbersCounter[num] += 1;
                }
            }

            foreach (var item in numbersCounter)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
