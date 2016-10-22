namespace _06_MaxSequenceOfEqualElements
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
            
            int len = 1;
            int start = 0;
            int bestStart = 0;
            int bestLen = 0;

            for (int pos = 1; pos <= nums.Count - 1; pos++)
            {
                if (nums[pos - 1] == nums[pos])
                {
                    len++;
                }
                else
                {
                    start = pos;
                    len = 1;
                }

                if (bestLen < len)
                {
                    bestLen = len;
                    bestStart = nums[start];
                }
            }

            for (int i = 0; i < bestLen; i++)
            {
                Console.Write($"{bestStart} ");
            }
        }
    }
}
