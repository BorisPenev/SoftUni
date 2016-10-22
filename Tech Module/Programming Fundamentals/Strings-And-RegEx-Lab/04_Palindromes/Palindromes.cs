namespace _04_Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Palindromes
    {
        static void Main()
        {
            var symbols = new char[] { ' ', ',', '.', '!', '?' };
            string[] words = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            foreach (var word in words)
            {
                if (IsPalindrome(word) && !palindromes.Contains(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(p => p)));

        }
        public static bool IsPalindrome(string word)
        {
            string reversedWord = GetReverseString(word);
            if (word.Equals(reversedWord))
            {
                return true;
            }

            return false;
        }

        public static string GetReverseString(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
