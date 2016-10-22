namespace _15_SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();
            ReverseItemsInList(nums);

            int sumOfReversedNumbers = nums.Select(int.Parse).Sum();

            Console.WriteLine(sumOfReversedNumbers);
        }

        public static void ReverseItemsInList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = ReverseString(list[i]);
            }
        }

        public static string ReverseString(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }
    }
}
