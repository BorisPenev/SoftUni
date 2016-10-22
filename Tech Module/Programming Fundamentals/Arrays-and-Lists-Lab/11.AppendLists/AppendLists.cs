namespace _11.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        static void Main()
        {
            List<string> inputArr = new List<string> (Console.ReadLine().Split('|').ToArray());
            List<int> result = new List<int>();

            for (int i = inputArr.Count - 1; i >= 0; i--)
            {
                foreach (string item in inputArr[i].Split(' '))
                {
                    if (item != string.Empty)
                    {
                        result.Add(int.Parse(item));
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
