using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number of centuries: ");
            ushort centuries = ushort.Parse(Console.ReadLine());
            uint years = (uint)(100 * centuries);
            ulong days = (ulong)(years* 365.2422);
            ulong hours = 24 * days;
            ulong minutes = 60 * hours;
            
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} ",
                centuries, years, days, hours, minutes);
        }
    }
}
