namespace _09.ExtractMiddleElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExtractMiddleElements
    {
        static void Main()
        {
            List<int> inputArr = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            int lenght = inputArr.Count;
            string result = string.Empty;

            if (lenght == 1)
            {
                result = "{" + $" {inputArr[0]} " + "}";
            }
            else if (lenght % 2 == 0)
            {
                result = "{" + $" {inputArr[lenght / 2 - 1]}, {inputArr[lenght / 2]} " + "}";
            }
            else
            {
                int middle = lenght / 2;
                result = "{" + $" {inputArr[middle - 1]}, {inputArr[middle]}, {inputArr[middle + 1]}" + "}";
            }

            Console.WriteLine(result);
        }
    }
}
