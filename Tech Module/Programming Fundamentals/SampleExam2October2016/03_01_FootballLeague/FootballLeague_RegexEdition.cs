namespace _03_01_FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class FootballLeague_RegexEdition
    {
        static void Main()
        {
            // REGEX EDITIONNNNNNMMMMMMMMMMMMMMM
            int winPoints = 3;
            int lossPoints = 0;
            int drawPoints = 1;
            Dictionary<string, Team> LeagueStandings = new Dictionary<string, Team>();

            //string pattern = @"(.*)(\?\?)([a-zA-Z]+)(\?\?)(.*)(\?\?)([a-zA-Z]+)(\?\?)(.*?)(\s)(.*)";
            
            string key = Console.ReadLine();
            string input = Console.ReadLine();

            string pattern = $"([{key}]\\w+[{key}])( )([{key}]\\w+[{key}])\\w+( )(\\d+):(\\d+)";
            Regex regex = new Regex(pattern);

            while (input != "final")
            {
                MatchCollection matches = regex.Matches(input);
                //int firstKeyIndex = input.IndexOf(key);
                //int nextKeyIndex = input.IndexOf(key, firstKeyIndex + key.Length);
                //string teamANameInReverse = input.Substring(firstKeyIndex + key.Length, nextKeyIndex - firstKeyIndex - key.Length);

                string teamAName = ReverseString(matches[0].Groups[3].Value).ToUpper();

                //string modifiedInput = input.Remove(0, nextKeyIndex + key.Length);
                //firstKeyIndex = modifiedInput.IndexOf(key);
                //nextKeyIndex = modifiedInput.IndexOf(key, firstKeyIndex + key.Length);

                //string teamBNameInReverse = modifiedInput.Substring(firstKeyIndex + key.Length, nextKeyIndex - firstKeyIndex - key.Length);

                string teamBName = ReverseString(matches[0].Groups[7].Value).ToUpper();

                string[] test = matches[0].Groups[11].Value
                    .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                uint teamAGoals = uint.Parse(test[test.Length - 2]);
                uint teamBGoals = uint.Parse(test[test.Length - 1]);

                if (!LeagueStandings.ContainsKey(teamAName))
                {
                    LeagueStandings.Add(teamAName, new Team() { Name = teamAName });
                }

                if (!LeagueStandings.ContainsKey(teamBName))
                {
                    LeagueStandings.Add(teamBName, new Team() { Name = teamBName });
                }

                if (LeagueStandings.ContainsKey(teamAName) && LeagueStandings.ContainsKey(teamBName))
                {
                    if (teamAGoals > teamBGoals)
                    {
                        LeagueStandings[teamAName].NumberOfGoals += teamAGoals;
                        LeagueStandings[teamAName].NumberOfPoints += winPoints;

                        LeagueStandings[teamBName].NumberOfGoals += teamBGoals;
                        LeagueStandings[teamBName].NumberOfPoints += lossPoints;
                    }
                    else if (teamAGoals == teamBGoals)
                    {
                        LeagueStandings[teamAName].NumberOfGoals += teamAGoals;
                        LeagueStandings[teamAName].NumberOfPoints += drawPoints;

                        LeagueStandings[teamBName].NumberOfGoals += teamBGoals;
                        LeagueStandings[teamBName].NumberOfPoints += drawPoints;
                    }
                    else
                    {
                        LeagueStandings[teamAName].NumberOfGoals += teamAGoals;
                        LeagueStandings[teamAName].NumberOfPoints += lossPoints;

                        LeagueStandings[teamBName].NumberOfPoints += winPoints;
                        LeagueStandings[teamBName].NumberOfGoals += teamBGoals;
                    }
                }

                input = Console.ReadLine();
            }

            PrintResult(LeagueStandings);
        }

        public static string ReverseString(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

        public static void PrintResult(Dictionary<string, Team> leagueStandings)
        {
            Console.WriteLine("League standings:");
            Dictionary<string, Team> league = leagueStandings
                .OrderByDescending(t => t.Value.NumberOfPoints)
                .ThenBy(t => t.Key)
                .ToDictionary(k => k.Key, k => k.Value);

            int counter = 1;
            foreach (KeyValuePair<string, Team> team in league)
            {
                Console.WriteLine($"{counter}. {team.Key} {team.Value.NumberOfPoints}");
                counter++;
            }

            Console.WriteLine("Top 3 scored goals:");
            Dictionary<string, Team> topThreeInGoals = leagueStandings
                .OrderByDescending(t => t.Value.NumberOfGoals)
                .ThenBy(t => t.Key)
                .Take(3)
                .ToDictionary(k => k.Key, k => k.Value);

            foreach (KeyValuePair<string, Team> team in topThreeInGoals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value.NumberOfGoals}");
            }
        }
    }

    public class Team
    {
        public string Name { get; set; }
        public uint NumberOfGoals { get; set; }
        public int NumberOfPoints { get; set; }
    }
}
