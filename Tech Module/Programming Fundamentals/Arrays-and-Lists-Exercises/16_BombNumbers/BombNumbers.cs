namespace _16_BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            while (nums.Contains(bomb))
            {
                int bombIndex = -1;

                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] == bomb)
                    {
                        bombIndex = i;
                        break;
                    }
                }
                
                int bombBlast = 2 * power + 1;
                int startIndex = Math.Max(0, bombIndex - power);
                int count = Math.Min(bombBlast, nums.Count - startIndex);
                nums.RemoveRange(startIndex, count);
                
            }
            Console.WriteLine(nums.Sum());
        }
    }
}
