namespace _02_CountSubstringOccurrences
{
    using System;

    public class CountSubstringOccurrences
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string searchTerm = Console.ReadLine().ToLower();

            Console.WriteLine(GetSubstringOccurrences(input, searchTerm));
        }

        public static int GetSubstringOccurrences(string input, string searchTerm)
        {
            int numberOfOccurrences = 0;
            int index = input.IndexOf(searchTerm);

            while (index != -1)
            {
                numberOfOccurrences++;
                index = input.IndexOf(searchTerm, index + 1);
            }

            return numberOfOccurrences;
        }
    }
}
