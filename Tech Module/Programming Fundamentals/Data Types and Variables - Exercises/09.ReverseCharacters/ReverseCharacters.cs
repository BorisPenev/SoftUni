using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ReverseCharacters
{
    class ReverseCharacters
    {
        static void Main(string[] args)
        {
            char firstLetter = Console.ReadLine()[0];
            char secondLetter = Console.ReadLine()[0];
            char thirdLetter = Console.ReadLine()[0];

            Console.WriteLine("{0}{1}{2}",thirdLetter, secondLetter, firstLetter);
        }
    }
}
