namespace _01_Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        static void Main()
        {
            //var input = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .ToList();
            bool hasMoreInput = true;
            Dictionary<string, Dictionary<string, string>> dict = new Dictionary<string, Dictionary<string, string>>();

            int counter = 0;
            while (hasMoreInput)
            {
                var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                if (input[counter] == "A")
                {
                    Dictionary<string, string> pair = new Dictionary<string, string>();
                    pair[input[counter + 1]] = input[counter + 2];

                    if (!dict["A"].ContainsKey(input[counter + 1]))
                    {
                        dict.Add("A",pair);
                    }
                    else
                    {
                        dict["A"] = pair;
                    }
                    //Dictionary<string, string> pair = new Dictionary<string, string>();
                    //pair[input[counter + 1]] = input[counter + 2];

                    //dict["A"] = pair;
                }
                else if (input[counter] == "S")
                {
                    Dictionary<string, string> pair = new Dictionary<string, string>();
                    pair[input[counter + 1]] = string.Empty;

                    dict["S"] = pair;
                    if (dict["A"].ContainsKey(input[counter + 1]))
                    {
                        Console.WriteLine("{0} -> {1}", input[counter + 1], dict["A"][input[counter + 1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input[counter + 1]);
                    }
                }
                else if (input[counter].Equals("END"))
                {
                    hasMoreInput = false;
                }
                
                counter = 0;
            }
        }
    }
}
