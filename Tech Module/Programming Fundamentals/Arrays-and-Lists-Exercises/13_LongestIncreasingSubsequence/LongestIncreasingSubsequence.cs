namespace _13_LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestIncreasingSubsequence
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
               .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToList();

            int[] len = new int[nums.Count];
            int[] prev = new int[nums.Count];
            int maxLen = 0;
            int lastIndex = -1;
            for (int x = 0; x < nums.Count; x++)
            {
                len[x] = 1;
                prev[x] = -1;
                for (int i = 0; i < x; i++)
                    if ((nums[i] < nums[x]) && (len[i] + 1 > len[x]))
                    {
                        len[x] = len[i] + 1;
                        prev[x] = i;
                    }
                if (len[x] > maxLen)
                {
                    maxLen = len[x];
                    lastIndex = x;
                }
            }

            var result = RestoreLIS(nums, prev, lastIndex);

            Console.WriteLine(string.Join(" ", result));
        }

        public static List<int> RestoreLIS(List<int> seq, int[] prev, int lastIndex)
        {
            var longestSeq = new List<int>();
            while (lastIndex != -1)
            {
                longestSeq.Add(seq[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            longestSeq.Reverse();
            return longestSeq.ToList();
        }

    }
}
