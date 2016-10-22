namespace _03.LastKNumbersSums
{
    using System;

    public class LastKNumbersSums
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] arrayOfInts = new long[n];
            arrayOfInts[0] = 1;
            
            for (int i = 1; i < arrayOfInts.Length; i++)
            {
                long sum = 0;
                int count = k;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (count == 0)
                    {
                        break;
                    }
                    sum += arrayOfInts[j];

                    count--;
                }

                arrayOfInts[i] = sum;
            }
            Console.WriteLine(string.Join(" ", arrayOfInts));
        }
    }
}
