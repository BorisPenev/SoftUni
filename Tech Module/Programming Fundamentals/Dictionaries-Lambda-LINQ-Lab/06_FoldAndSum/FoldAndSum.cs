namespace _06_FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(str => int.Parse(str)).ToList();

            int k = input.Count / 4;
            int midleSize = 2 * k;

            var row1LeftSide = input.Take(k).Reverse().ToList();
            var row1RightSide = input.Skip(3*k).Reverse().ToList();
            var row1 = row1LeftSide.Concat(row1RightSide).ToList();
            var row2 = input.Skip(k).Take(midleSize).ToList();

            var sumArr = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
