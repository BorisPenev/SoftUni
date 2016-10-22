namespace _07_MaxSequenceOfIncreasingElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfIncreasingElements
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            
            int cntCurrSeq = 0;
            int startCurrSeq = 0;
            int cntMaxSeq = 0;
            int startMaxSeq = 0;

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] - nums[i - 1] >= 1)
                {
                    cntCurrSeq++;
                    startCurrSeq = i - cntCurrSeq;

                    if (cntCurrSeq > cntMaxSeq)
                    {
                        cntMaxSeq = cntCurrSeq;
                        startMaxSeq = startCurrSeq;
                    }
                }
                else
                {
                    cntCurrSeq = 0;
                }
            }

            for (int i = startMaxSeq; i <= (startMaxSeq + cntMaxSeq); i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
