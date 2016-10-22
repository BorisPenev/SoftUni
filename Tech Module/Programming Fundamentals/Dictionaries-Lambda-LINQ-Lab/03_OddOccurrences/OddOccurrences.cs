namespace _03_OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class _03_OddOccurrences
    {
        static void Main()
        {
            List<string> words = Console.ReadLine().ToLower()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount[word] = 1;
                }
                else
                {
                    wordsCount[word] += 1;
                }
            }

            List<string> resultsList = new List<string>();

            foreach (var item in wordsCount)
            {
                if (item.Value % 2 != 0)
                {
                    resultsList.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", resultsList));
        }
    }
}
