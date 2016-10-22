using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOf_ASCII_Table
{
    class PrintPartOf_ASCII_Table
    {
        static void Main(string[] args)
        {
            int startAsciiSymbol = int.Parse(Console.ReadLine());
            int endAsciiSymbol = int.Parse(Console.ReadLine());

            for (int asciiSymbol = startAsciiSymbol; asciiSymbol <= endAsciiSymbol; asciiSymbol++)
            {
                Console.Write("{0} ",(char)asciiSymbol);
            }
        }
    }
}
