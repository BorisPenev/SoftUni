using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine().ToLower();
            string vowels = "aeiou";
            
            if (symbol[0] >= '0' && symbol[0] <= '9')
            {
                Console.WriteLine("digit");
            }            
            else if (vowels.Contains(symbol))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
