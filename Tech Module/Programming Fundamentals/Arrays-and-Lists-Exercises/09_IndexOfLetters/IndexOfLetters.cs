namespace _09_IndexOfLetters
{
    using System;
    using System.Collections.Generic;

    public class IndexOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<char> alphabet = new List<char>();
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet.Add(i);
            }

            foreach (char symbol in input)
            {
                int index = alphabet.IndexOf(symbol);
                if (symbol.Equals(alphabet[index]))
                {
                    Console.WriteLine("{0} -> {1}", alphabet[index], index);
                }
            }
        }
    }
}
