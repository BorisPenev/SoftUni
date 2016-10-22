namespace _05_ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class _05_ShortWordsSorted
    {
        static void Main()
        {
            List<string> words = Console.ReadLine().ToLower()
                .Split(new char[]
                {
                    ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '/', '\\', '!', '?'
                }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var shortSortedWords = (words
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(x => x));

            Console.WriteLine(string.Join(", ", shortSortedWords));
        }
    }
}
