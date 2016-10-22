namespace _12.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            List<double> arr = new List<double>(Console.ReadLine().Split(' ').Select(double.Parse).ToArray());
            
            for (int i = 1; i < arr.Count;)
            {
                if (arr[i] == arr[i - 1])
                {
                    arr[i] += arr[i - 1];
                    arr.RemoveAt(i - 1);
                    i = 1;
                }
                else
                {
                    i++;
                }
            }

            // Another way to do it with a While loop
            //int counter = 1;
            //while (counter < arr.Count)
            //{
            //    if (arr[counter - 1] == arr[counter])
            //    {
            //        int sum = arr[counter - 1] + arr[counter];

            //        arr[counter] = sum;
            //        arr.RemoveAt(counter - 1);

            //        counter = 1;
            //    }
            //    else
            //    {
            //        counter++;
            //    }
            //}

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
