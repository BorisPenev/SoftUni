namespace _02_RandomizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RandomizeWords
    {
        static void Main()
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            Random rnd = new Random();
            for (int i = 0; i < words.Count; i++)
            {
                int position = rnd.Next(0, words.Count);

                string temp = words[i];
                words[i] = words[position];
                words[position] = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
