﻿namespace _01_Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, string> addressBook = new Dictionary<string, string>();
            while (input[0] != "END")
            {

                if (input[0].Equals("A"))
                {
                    if (!addressBook.ContainsKey(input[1]))
                    {
                        addressBook.Add(input[1], input[2]);
                    }
                    else
                    {
                        addressBook[input[1]] = input[2];
                    }
                }
                else if (input[0].Equals("S"))
                {
                    if (addressBook.ContainsKey(input[1]))
                    {
                        Console.WriteLine("{0} -> {1}", input[1], addressBook[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                    }
                }

                input = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
