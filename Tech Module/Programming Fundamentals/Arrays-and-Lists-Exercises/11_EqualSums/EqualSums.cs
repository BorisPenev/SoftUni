namespace _11_EqualSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSums
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
              .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse).ToList();

            int leftSum = 0;
            int rightSum = 0;
            
            bool areSumsEqual = false;
            if (nums.Count == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < nums.Count; i++)
            {
                int middleIndex = i;

                for (int j = 0; j < middleIndex; j++)
                {
                    leftSum += nums[j];
                }
                
                for (int j = middleIndex + 1; j < nums.Count; j++)
                {
                    rightSum += nums[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine("{0}", i);
                    areSumsEqual = true;
                    break;
                }

                rightSum = 0;
                leftSum = 0;
            }

            if (!areSumsEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
