namespace _03_FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int k = nums.Count / 4;            
            int midleSize = 2 * k;

            var row1LeftSide = nums.Take(k).Reverse().ToList();
            var row1RightSide = nums.Skip(3 * k).Reverse().ToList();
            var row1 = row1LeftSide.Concat(row1RightSide).ToList();
            var row2 = nums.Skip(k).Take(midleSize).ToList();

            var sumArr = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
