namespace _03_TextFilter
{
    using System;

    public class _03_TextFilter
    {
        static void Main()
        {
            char[] symbols = new char[] { ' ', ',' };
            string[] banWords = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (string word in banWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
