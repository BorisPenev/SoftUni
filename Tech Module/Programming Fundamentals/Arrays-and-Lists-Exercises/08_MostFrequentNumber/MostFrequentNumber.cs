namespace _08_MostFrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MostFrequentNumber
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            Dictionary<int, int> countNums = new Dictionary<int, int>();
            foreach (int num in nums.Distinct())
            {
                int count = nums.Count(n=> n == num);
                countNums.Add(num, count);
            }

            var maxValue = countNums.Max(n => n.Value);
            Console.WriteLine(countNums.FirstOrDefault(v => v.Value == maxValue).Key);
        }
    }
}
