﻿namespace _18.Substring
{
    using System;

    public class Substring
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                int endIndex = jump + 1;

                if (text[i] == Search)
                {
                    hasMatch = true;

                    if (i + endIndex > text.Length - 1)
                    {
                        endIndex = text.Length - i;
                    }

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
