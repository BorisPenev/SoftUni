namespace _13.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        static void Main()
        {
            List<string> words = Console.ReadLine().Split(new char[]
            {
                ',', ';', ':', '.', '!',
                '(', ')', '"', '\'', '\\', '/', '[', ']', ' '}).ToList<string>();
            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            foreach (string word in words)
            {
                if (word == string.Empty)
                {
                    continue;
                }

                if (IsLowerCaseWord(word))
                {
                    lowerCaseWords.Add(word);
                }
                else if (IsUpperCaseWord(word))
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", PrintWords(lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", PrintWords(mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", PrintWords(upperCaseWords));
        }

        public static string PrintWords(List<string> words)
        {
            return string.Join(", ", words);
        }

        public static bool IsLowerCaseWord(string word)
        {
            foreach (char letter in word)
            {
                if (char.IsUpper(letter) || !char.IsLetter(letter))
                    return false;
            }

            return true;
        }

        public static bool IsUpperCaseWord(string word)
        {
            foreach (char letter in word)
            {
                if (char.IsLower(letter) || !char.IsLetter(letter))
                    return false;
            }

            return true;
        }
    }
}
