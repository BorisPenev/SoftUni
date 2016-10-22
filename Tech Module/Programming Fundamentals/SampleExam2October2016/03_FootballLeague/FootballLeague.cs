namespace _03_FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FootballLeague
    {
        static void Main()
        {
            int winPoints = 3;
            int lossPoints = 0;
            int drawPoints = 1;
            Dictionary<string, Team> LeagueStandings = new Dictionary<string, Team>();
            
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            
            while (input != "final")
            {
                int firstKeyIndex = input.IndexOf(key);
                int nextKeyIndex = input.IndexOf(key, firstKeyIndex + key.Length);
                string teamANameInReverse = input.Substring(firstKeyIndex + key.Length, nextKeyIndex - firstKeyIndex - key.Length);

                string teamAName = ReverseString(teamANameInReverse).ToUpper();

                string modifiedInput = input.Remove(0, nextKeyIndex + key.Length);
                firstKeyIndex = modifiedInput.IndexOf(key);
                nextKeyIndex = modifiedInput.IndexOf(key, firstKeyIndex + key.Length);

                string teamBNameInReverse = modifiedInput.Substring(firstKeyIndex + key.Length, nextKeyIndex - firstKeyIndex - key.Length);

                string teamBName = ReverseString(teamBNameInReverse).ToUpper(); 

                string[] score = modifiedInput
                    .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                uint teamAGoals = uint.Parse(score[score.Length - 2]);
                uint teamBGoals = uint.Parse(score[score.Length - 1]);

                if (!LeagueStandings.ContainsKey(teamAName))
                {
                    LeagueStandings.Add(teamAName, new Team() {Name = teamAName });
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

            Console.WriteLine("League standings:");
            Dictionary<string, Team> league = LeagueStandings
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
            Dictionary<string, Team> topThreeInGoals = LeagueStandings
                .OrderByDescending(t => t.Value.NumberOfGoals)
                .ThenBy(t => t.Key)
                .Take(3)
                .ToDictionary(k => k.Key, k => k.Value);

            foreach (KeyValuePair<string, Team> team in topThreeInGoals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value.NumberOfGoals}");
            }
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
    }

    public class Team
    {
        public string Name { get; set; }
        public uint NumberOfGoals { get; set; }
        public int NumberOfPoints { get; set; }
    }
}
