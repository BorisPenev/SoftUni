using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            int pictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long overallFilterTime = (long)pictures * filterTime;
            long filteredPictures = (long)Math.Ceiling((double)(pictures * filterFactor / 100.0));
            long overallUploadTime = filteredPictures * uploadTime;

            long time = (long)(overallUploadTime + overallFilterTime);
            TimeSpan totalTime = TimeSpan.FromSeconds(time);

            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", 
                totalTime.Days, 
                totalTime.Hours,
                totalTime.Minutes, 
                totalTime.Seconds );
        }
    }
}
