using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            ulong milliseconds = (ulong)(seconds * 1000);
            BigInteger microseconds = BigInteger.Multiply(milliseconds, 1000);
            BigInteger nanoseconds = BigInteger.Multiply(microseconds, 1000);

            /*
             1 centuries = 100 years = 36524 days = 876576 
             hours = 52594560 minutes = 3155673600 seconds = 3155673600000 milliseconds
             = 3155673600000000 microseconds = 3155673600000000000 nanoseconds
             */
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}
