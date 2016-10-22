namespace _04_FixEmail
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FixEmail
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> emailBook = new Dictionary<string, string>();
            long lineCounter = 1;
            string name = "";
            string email = "";

            while (input != "stop")
            {
                if (lineCounter % 2 != 0)
                {
                    name = input;
                    if (!emailBook.ContainsKey(name))
                    {
                        emailBook.Add(name, "");
                    }
                }
                else
                {
                    email = input;
                    emailBook[name] = email;
                }
                lineCounter++;
                input = Console.ReadLine();
            }

            emailBook = emailBook.Where(e => !e.Value.EndsWith("us") && !e.Value.EndsWith("uk")).ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<string, string> pair in emailBook)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
