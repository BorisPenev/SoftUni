namespace _05_CompareCharArrays
{
    using System;
    using System.Collections.Generic;

    public class CompareCharArrays
    {
        static void Main()
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');

            List<char> charArr = new List<char>();
            List<char> secondCharArr = new List<char>();

            for (int i = 0; i < firstArr.Length; i++)
            {
                charArr.Add(char.Parse(firstArr[i]));
            }

            for (int i = 0; i < secondArr.Length; i++)
            {
                secondCharArr.Add(char.Parse(secondArr[i]));
            }

            int len = Math.Min(charArr.Count, secondCharArr.Count);
            bool areDifferent = false;

            for (int i = 0; i < len; i++)
            {
                if (charArr[i] > secondCharArr[i])
                {
                    Console.WriteLine(string.Join("",secondCharArr));
                    Console.WriteLine(string.Join("",charArr));
                    areDifferent = true;

                    break;
                }
                else if (charArr[i] < secondCharArr[i])
                {                
                    Console.WriteLine(string.Join("", charArr));
                    Console.WriteLine(string.Join("", secondCharArr));
                    areDifferent = true;

                    break;
                }
            }

            if (!areDifferent)
            {
                if (charArr.Count <= secondCharArr.Count)
                {
                    Console.WriteLine(string.Join("", charArr));
                    Console.WriteLine(string.Join("", secondCharArr));
                }
                else
                {
                    Console.WriteLine(string.Join("", secondCharArr));
                    Console.WriteLine(string.Join("", charArr));
                }
            }
        }
    }
}
