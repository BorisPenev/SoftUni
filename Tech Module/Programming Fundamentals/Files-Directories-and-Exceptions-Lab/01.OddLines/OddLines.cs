namespace _01.OddLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class OddLines
    {
        static void Main()
        {
            string[] file = File.ReadAllLines(@"../../Input.txt");
            
            File.WriteAllLines(@"../../Output.txt", file.Where((x, index) => index % 2 == 1).ToArray());            
        }
    }
}
