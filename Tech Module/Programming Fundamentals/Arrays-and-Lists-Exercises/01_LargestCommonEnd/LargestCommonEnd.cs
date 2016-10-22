namespace _01_LargestCommonEnd
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class LargestCommonEnd
    {
        static void Main()
        {
            List<string> firstList = Console.ReadLine().Split(new char[] { ' ', ',' }).ToList<string>();
            List<string> secondList = Console.ReadLine().Split(new char[] { ' ', ',' }).ToList<string>();

            int commonElementsLeft = 0;
            int commonElementsRight = 0;

            int shorterLenght = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < shorterLenght; i++)
            {
                if (firstList[i] == secondList[i])
                {
                    commonElementsLeft++;
                    continue;
                }

                break;
            }
            
            for (int i = 1; i <= shorterLenght; i++)
            {
                if (firstList[firstList.Count - i] == secondList[secondList.Count - i])
                {
                    commonElementsRight++;
                    continue;
                }

                break;
            }

            Console.WriteLine(Math.Max(commonElementsLeft, commonElementsRight));           
        }
    }
}
