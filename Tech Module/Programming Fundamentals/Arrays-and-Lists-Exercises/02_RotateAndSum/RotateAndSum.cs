namespace _02_RotateAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RotateAndSum
    {
        static void Main()
        {
            List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            int rotations = int.Parse(Console.ReadLine());
            
            List<long> sum = new List<long>(nums.Count);

            if (rotations == 0)
            {
                long[] dummyArr = new long[nums.Count];
                Console.WriteLine(String.Join(" ", dummyArr));
            }
            else
            {
                
                for (int i = 0; i < rotations; i++)
                {
                    long lastElement = nums.Last();
                    nums.Insert(0, lastElement);
                    nums.RemoveAt(nums.Count - 1);

                    if (sum.Count == 0)
                    {
                        sum.AddRange(nums);
                    }
                    else
                    {
                        for (int index = 0; index < nums.Count; index++)
                        {
                            sum[index] += nums[index];
                        }
                    }
                }

                Console.WriteLine(String.Join(" ", sum));
            }
        }
    }
}
