namespace _03_AMinersTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class AMinersTask
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, long> minersResourceBook = new Dictionary<string, long>();
            long lineCounter = 1;
            string resource = "";
            int quantity = 0;

            while (input != "stop")
            {
                if (lineCounter % 2 != 0)
                {
                    resource = input;
                    if (!minersResourceBook.ContainsKey(resource))
                    {
                        minersResourceBook.Add(resource, 0);
                    }
                }
                else
                {
                    quantity = int.Parse(input);
                    minersResourceBook[resource] += quantity;
                }
                lineCounter++;
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, long> pair in minersResourceBook)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
