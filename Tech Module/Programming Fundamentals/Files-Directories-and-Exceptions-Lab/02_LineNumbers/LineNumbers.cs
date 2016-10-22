namespace _02_LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines(@"../../Input.txt");

            File.WriteAllLines(@"../../Output.txt",
                lines.Select((line, index) => line = string.Format("{0}. {1}", index + 1, line)).ToArray());
        }
    }
}
