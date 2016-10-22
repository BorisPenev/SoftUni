namespace _03_UnicodeCharacters
{
    using System;
    using System.Text;

    public class _03_UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (char symbol in input)
            {
                sb.Append($"\\u{(int)symbol:x4}");
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}
