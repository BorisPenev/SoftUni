using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float calculatedSecond = hours * 3600 + minutes * 60 + seconds;
            float metersPerSeconds = distanceInMeters / calculatedSecond;

            float calculatedHours = hours + minutes / 60 + seconds / 3600;
            float kilometersPerHour = (distanceInMeters / 1000) / calculatedHours;

            float milesPerHour = (distanceInMeters / 1609) / calculatedHours;

            Console.WriteLine(metersPerSeconds);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
            /*
             * l = s * t
             * s = l / t
            •	On first line – speed in meters per second (m/s)
            •	On second line – speed in kilometers per hour (km/h)
            •	On third line – speed in miles per hour (mph)

            */
        }
    }
}
