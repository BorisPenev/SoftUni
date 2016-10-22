namespace _07.SumArrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        static void Main()
        {
            int[] firstInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            if (firstInput.Length >= secondInput.Length)
            {
                int[] resultArr = new int[firstInput.Length];

                int index = 0;
                for (int i = 0; i < firstInput.Length; i++)
                {
                    if (i <= secondInput.Length - 1)
                    {
                        index = i;    
                        resultArr[i] = firstInput[i] + secondInput[index];
                    }
                    else
                    {
                        index++;

                        if (index >= secondInput.Length)
                        {
                            index = 0;
                        }

                        resultArr[i] = firstInput[i] + secondInput[index];
                    }
                    
                }
                Console.WriteLine(string.Join(" ", resultArr));
            }
            else
            {
                int[] resultArr = new int[secondInput.Length];

                int index = 0;
                for (int i = 0; i < secondInput.Length; i++)
                {
                    if (i <= firstInput.Length - 1)
                    {
                        index = i;
                        resultArr[i] = secondInput[i] + firstInput[index];
                    }
                    else
                    {
                        index++;

                        if (index >= firstInput.Length)
                        {
                            index = 0;
                        }

                        resultArr[i] = secondInput[i] + firstInput[index];
                    }

                }
                Console.WriteLine(string.Join(" ", resultArr));
            }

        }
    }
}
