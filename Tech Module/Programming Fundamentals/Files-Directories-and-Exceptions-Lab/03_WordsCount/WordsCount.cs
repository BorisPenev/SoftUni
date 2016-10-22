namespace _03_WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordsCount
    {
        static void Main()
        {
            string[] words = File.ReadAllText(@"../../words.txt").ToLower().Split(' ');
            string[] text = File.ReadAllText(@"../../text.txt").ToLower()
                .Split(new char[] { ' ', '-', '?','!', '.', ','}, 
                StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> countedWords = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!countedWords.ContainsKey(words[i]))
                {
                    countedWords.Add(words[i], 0);
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (countedWords.ContainsKey(text[i]))
                {
                    countedWords[text[i]] += 1;
                }
            }

            countedWords = countedWords.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            File.WriteAllText("../../result.txt", "");

            foreach (var item in countedWords)
            {
                File.AppendAllText("../../result.txt", $"{item.Key} - {item.Value}\r\n");
            }
        }
    }
}
