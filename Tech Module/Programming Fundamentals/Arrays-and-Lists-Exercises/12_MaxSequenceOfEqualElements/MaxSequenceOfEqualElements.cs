namespace _12_MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            
            int maxCount = int.MinValue;
            int maxNumberIndex = 0;

            
            for (int pos = 0; pos < nums.Count; pos++)
            {
                int currentNumberCount = nums.Count(n => n == nums[pos]);
                int currentNumberIndex = pos;

                if (maxCount < currentNumberCount)
                {
                    maxCount = currentNumberCount;
                    maxNumberIndex = currentNumberIndex;
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < maxCount; i++)
            {
                result.Add(nums[maxNumberIndex]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
