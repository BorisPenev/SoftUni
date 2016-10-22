namespace _03_RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class _03_RageQuit
    {
        static void Main()
        {
            string input = Console.ReadLine().ToUpper();
            string rgx = "(\\D+)(\\d+)";
            Regex regex = new Regex(rgx);
            int count = 0;
            int distinctSymbols = input.Distinct().Where(s => !char.IsDigit(s)).Count();
            //Console.WriteLine($"Unique symbols used: {distinctSymbols}");
            StringBuilder output = new StringBuilder();
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string symbols = match.Groups[1].ToString();
                int repeatCount = int.Parse(match.Groups[2].ToString());

                for (int i = 0; i < repeatCount; i++)
                {
                    output.Append(match.Groups[1]);
                    //Console.Write("{0}", symbols);
                }
            }

            count = output.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine($"{output}");
        }
    }
}
