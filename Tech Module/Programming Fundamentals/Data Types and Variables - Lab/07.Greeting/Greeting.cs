﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            uint age = uint.Parse(Console.ReadLine());

            string result = $"Hello {firstName} {lastName}.\r\nYou are {age} years old.";
            Console.WriteLine(result);
        }
    }
}
