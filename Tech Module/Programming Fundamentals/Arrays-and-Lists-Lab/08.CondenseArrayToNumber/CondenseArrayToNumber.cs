namespace _08.CondenseArrayToNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        static void Main()
        {
            List<int> inputArr = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            int counter = 0;
            int condensedNumber = 0;

            if (inputArr.Count == 1)
            {
                Console.WriteLine(inputArr[0]);
                return;
            }

            while ( counter < inputArr.Count)
            {
                if (counter < inputArr.Count - 1)
                {
                    int sum = inputArr[counter] + inputArr[counter + 1];
                    inputArr[counter] = sum;
                    counter++;
                }
                else
                {
                    counter = 0;
                    if (inputArr.Count ==  1)
                    {
                        condensedNumber = inputArr[0];
                        break;
                    }

                    inputArr.RemoveAt(inputArr.Count - 1);
                }   
            }

            Console.WriteLine(condensedNumber);
        }
    }
}
