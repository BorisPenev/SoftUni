namespace _04.TrippleSum
{
    using System;

    public class TrippleSum
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[input.Length];
            bool isFound = false;
            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int firstNum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        int secondNum = arr[j];
                        int sum = firstNum + secondNum;

                        foreach (int num in arr)
                        {
                            if (num == sum)
                            {
                                Console.WriteLine($"{firstNum} + {secondNum} == {sum}");
                                isFound = true;
                                break;
                            }
                        }
                    }
                }                
            }
            if (!isFound)
            {
                Console.WriteLine("No");
            }

        }
        
    }
}
