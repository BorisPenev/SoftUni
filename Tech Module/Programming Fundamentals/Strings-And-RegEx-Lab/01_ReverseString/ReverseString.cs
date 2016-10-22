namespace _01_ReverseString
{
    using System;
    using System.Text;

    public class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetReverseString(input));
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
