namespace _01_ConvertFromBaseTenToBaseN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class _01_ConvertFromBaseTenToBaseN
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Trim().Split();
            int baseN = int.Parse(line[0]);
            List<BigInteger> result = new List<BigInteger>();
            
            BigInteger num = BigInteger.Parse(line[1]);

            while (num != 0)
            {
                BigInteger remainder = num % baseN;
                result.Add(remainder);
                num = num / baseN;
            }
            result.Reverse();  
            
            Console.WriteLine(string.Join("", result));
        }
    }
}
