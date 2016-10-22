namespace _10.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        static void Main()
        {
            List<int> inputArr = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            int i = 0;
            while (i < inputArr.Count)
            {
                if (inputArr[i] < 0)
                {
                    inputArr.RemoveAt(i);
                }
                else
                {
                    i++;
                }

                if (inputArr.Count == 0) break;
            }

            if (inputArr.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                inputArr.Reverse();
                Console.WriteLine(string.Join(" ", inputArr));
            }
        }
    }
}
