namespace _04_CubicMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class _04_CubicMessages
    {

        static void Main()
        {
            string encryptedMessAGE = Console.ReadLine();

            while (encryptedMessAGE != "Over!")
            {
                int count = int.Parse(Console.ReadLine());
                string pattern = @"^([0-9]+)([a-zA-Z]{" + count + @"})([^a-zA-Z]*)$";

                Match match = Regex.Match(encryptedMessAGE, pattern);
                 
                if (match.Success)
                {
                    string message = match.Groups[2].ToString();
                    Console.Write(message + " == ");
                    List<int> indexes = GetIndexes(match);

                    foreach (var i in indexes)
                    {
                        if (i >= 0 && i < message.Length)
                        {
                            Console.Write(message[i]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

                encryptedMessAGE = Console.ReadLine();
            }
        }

        private static List<int> GetIndexes(Match match)
        {
            List<int> indexes = new List<int>();
            string left = match.Groups[1].ToString();

            for (int i = 0; i < left.Length; i++)
            {
                if (char.IsDigit(left[i]))
                {
                    indexes.Add(int.Parse(left[i].ToString()));
                }
            }

            string right = match.Groups[3].ToString();

            for (int i = 0; i < right.Length; i++)
            {
                if (char.IsDigit(right[i]))
                {
                    indexes.Add(int.Parse(right[i].ToString()));
                }
            }

            return indexes;
        }
    }
}
