namespace _04_MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MergeFiles
    {
        static void Main()
        {
            string[] fileOneText = File.ReadAllLines(@"../../FileOne.txt");
            string[] fileTwoText = File.ReadAllLines(@"../../FileTwo.txt");

            List<string> output = new List<string>();

            output.AddRange(fileOneText);
            //foreach (var item in fileOneText)
            //{
            //    output.Add(item);
            //}
            //foreach (var item in fileTwoText)
            //{
            //    output.Add(item);
            //}
            output.AddRange(fileTwoText);
            output = output.OrderBy(x => x).ToList();
            File.WriteAllText(@"../../result.txt", "");

            File.WriteAllLines(@"../../result.txt", output);
        }
    }
}
