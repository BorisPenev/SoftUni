namespace _10_PairsByDifference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PairsByDifference
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            int difference = int.Parse(Console.ReadLine());
            int pairCount = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = 0; j < nums.Count; j++)
                {
                    if (nums[i] - nums[j] == difference)
                    {
                        pairCount++;
                    }
                }
            }

            Console.WriteLine(pairCount);
        }
    }
}
